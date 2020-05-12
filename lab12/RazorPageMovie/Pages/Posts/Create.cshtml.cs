using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;
using System.Threading.Tasks;

namespace RazorPageMovie.Pages.Posts
{
    public class CreateModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();

        [BindProperty] public Post PostDTO { get; set; }

        public IActionResult OnGet() 
        {
            return Page(); 
        }
        public async Task<IActionResult> OnPostAsync() 
        {
            if (!ModelState.IsValid) 
            { 
                return Page(); 
            }
            Post post = new Post(); 
            post.Domain = PostDTO.Domain; 
            post.Description = PostDTO.Description; 
            post.Date = PostDTO.Date; 
            var result = await pcc.AddPostAsync(post); 
            if (!result) {
                return RedirectToAction("Error"); 
            }
            return RedirectToPage("./Index"); }
    }
}