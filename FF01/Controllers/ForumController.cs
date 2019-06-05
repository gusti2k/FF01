using FF01.Data;
using FF01.Models.Forum;
using Microsoft.AspNetCore.Mvc;
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

            var postListings = 
            var posts = _postService.GetFilteredPosts(id);
            return null;
        }
    }
}