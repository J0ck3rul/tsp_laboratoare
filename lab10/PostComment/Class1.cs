using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostComment
{
    public partial class Post
    {
        public bool AddPost()
        {
            using (Model1Container ctx = new Model1Container())
            {
                bool bResult = false;
                if (this.PostId == 0)
                {
                    var it = ctx.Entry<Post>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Post UpdatePost(Post newPost)
        {
            using (Model1Container ctx = new Model1Container())
            {
                Post oldPost = ctx.Posts.Find(newPost.PostId);
                if (oldPost == null)
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public int DeletePost(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid =@p0", id);
            }
        }
        public Post GetPostById(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p;
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null;
            }
        }
        public List<Post> GetAllPosts()
        {
            using (Model1Container ctx = new Model1Container())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
            }
        }
    }

    public partial class Comment
    {
        public bool AddComment()
        {
            using (Model1Container ctx = new Model1Container())
            {
                bool bResult = false;
                if (this == null || this.CommentId == 0)
                    return bResult;
                if (this.CommentId == 0)
                {
                    ctx.Entry<Comment>(this).State = EntityState.Added;
                    Post p = ctx.Posts.Find(this.PostPostId);
                    ctx.Entry<Post>(p).State = EntityState.Unchanged;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Comment UpdateComment(Comment newComment)
        {
            using (Model1Container ctx = new Model1Container())
            {
                Comment oldComment = ctx.Comments.Find(newComment.CommentId);
                if (newComment.Text != null)
                    oldComment.Text = newComment.Text;
                if ((oldComment.PostPostId != newComment.PostPostId) && (newComment.PostPostId != 0))
                {
                    oldComment.PostPostId = newComment.PostPostId;
                }
                ctx.SaveChanges();
                return oldComment;
            }
        }
        public Comment GetCommentById(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var items = from c in ctx.Comments where (c.CommentId == id) select c;
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }
    }
}
