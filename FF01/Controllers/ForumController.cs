using FF01.Data;
using FF01.Data.Models;
using FF01.Models.Forum;
using FF01.Models.Post;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FF01.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;


        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }
        public IActionResult Index()
        {
            //IEnumerable<ForumListingModel> forums = _forumService.GetAll();
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description
                });

            var model = new ForumIndexModel
            {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetByID(id);
            //var posts = _postService.GetPostsByForum(id); REFACTORING 
            var posts = forum.Posts;

            var postListings = posts.Select(p => new PostListingModel
            {
                Id = p.Id,
                AuthorId = p.User.Id,
                AuthorRating = p.User.Rating,
                Title = p.Title,
                DatePoster = p.Created,
                RepliesCount = p.Replies.Count(),
                Forum = BuildForumListing(p)
            });

            var model = new ForumTopicModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };

            return View(model) ;
        }

        private ForumListingModel BuildForumListing(Forum forum)
        {          
            return new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl
            };
        }
        private ForumListingModel BuildForumListing(Post p)
        {
            var forum = p.Forum;

           return BuildForumListing(p);
        }
    }
}