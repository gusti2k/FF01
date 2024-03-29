﻿using FF01.Models.Forum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FF01.Models.Post
{
    public class PostListingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int AuthorRating { get; set; }
        public string AuthorId  { get; set; }
        public DateTime DatePoster { get; set; }

        public ForumListingModel Forum { get; set; }

        public int RepliesCount { get; set; }

    }
}
