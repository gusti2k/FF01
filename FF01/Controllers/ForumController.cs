using FF01.Data;
using FF01.Data.Models;
using FF01.Models.Forum;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FF01.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;


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
    }
}