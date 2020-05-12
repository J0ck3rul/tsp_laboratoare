using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostComment
{
    public class Class1
    {
    }

    public partial class Post
    {
        //    public bool AddPost()
        //    {
        //        using (PostContainer context = new PostContainer())
        //        {
        //            bool bResult = false;
        //            if (PostId == 0)
        //            {
        //                context.Entry<Post>(this).State = EntityState.Added;
        //                context.SaveChanges();
        //                bResult = true;
        //            }
        //            return bResult;
        //        }

        //    }

        //    public Post UpdatePost(Post newPost)
        //    {
        //        using (PostContainer context = new PostContainer())
        //        {
        //            Post oldPost = context.Posts.Find(newPost.PostId);
        //            if (oldPost == null) // nu exista in bd
        //            {
        //                return null;
        //            }
        //            oldPost.Description = newPost.Description;
        //            oldPost.Domain = newPost.Domain;
        //            oldPost.Date = newPost.Date;
        //            context.SaveChanges();
        //            return oldPost;
        //        }
        //    }
        //    public int DeletePost(int id)
        //    {
        //        using (PostContainer context = new PostContainer())
        //        {
        //            return context.Database.ExecuteSqlCommand("Delete From Post where postid = @p0", id);
        //        }
        //    }
        //    public Post GetPostById(int id)
        //    {
        //        using (PostContainer context = new PostContainer())
        //        {
        //            var items = from p in context.Posts where (p.PostId == id) select p;
        //            if (items != null)
        //                return items.Include(c => c.Comments).SingleOrDefault();
        //            return null; // trebuie verificat in apelant
        //        }
        //    }
        //    public List<Post> GetAllPosts()
        //    {
        //        using (PostContainer context = new PostContainer())
        //        {
        //            return context.Posts.Include("Comments").ToList<Post>();
        //        }
        //    }
    }
}