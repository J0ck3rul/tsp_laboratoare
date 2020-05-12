using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;

namespace RazorPageMovie.Pages.Posts
{
    public class IndexModel : PageModel
    {


        PostCommentClient pcc = new PostCommentClient();
        public List<Post> Posts { get; set; }

        public IndexModel() { Posts = new List<Post>(); }

        public async Task OnGetAsync()
        {
            var posts = await pcc.GetPostsAsync(); 
            foreach (var item in posts)
            {
                Post pd = new Post();
                pd.Description = item.Description;
                pd.PostId = item.PostId;
                pd.Domain = item.Domain;
                pd.Date = item.Date;
                foreach (var cc in item.Comments)
                {
                    Comment cdto = new Comment();
                    cdto.PostPostId = cc.PostPostId;
                    cdto.Text = cc.Text;
                    pd.Comments.Append(cdto);
                }
                Posts.Add(pd);
            }
        }

    }
}