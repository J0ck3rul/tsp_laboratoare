using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using PostComment;

namespace GrpcGreeter
{
    public class GreeterService : Greeter.GreeterBase, IPostComment
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        bool InterfaceComment.AddComment(Comment comment)
        {
            return comment.AddComment();
        }
        bool InterfacePost.AddPost(Post post)
        {
            return post.AddPost();
        }
        int InterfacePost.DeletePost(int id)
        {
            Post post = new Post();
            return post.DeletePost(id);
        }
        Comment InterfaceComment.GetCommentById(int id)
        {
            Comment comment = new Comment(); return comment.GetCommentById(id);
        }
        Post InterfacePost.GetPostById(int id)
        {
            Post post = new Post();
            Console.WriteLine("GetPostById. Id = {0}", id);
            post = post.GetPostById(id);
            Console.WriteLine("Post returnat. Id = {0} , Description = {1}", post.PostId, post.Description);
            return post;
        }
        List<Post> InterfacePost.GetPosts()
        {
            Post post = new Post();
            return post.GetAllPosts();
        }
        Comment InterfaceComment.UpdateComment(Comment newComment)
        {
            return newComment.UpdateComment(newComment);
        }
        Post InterfacePost.UpdatePost(Post post)
        {
            return post.UpdatePost(post);
        }
    }

}
