using FF01.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FF01.Controllers
{
    public class PostController
    {
        private readonly IPost _postService;
        public PostController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Index(int id)
        {
            return null;
        }
    }
}
