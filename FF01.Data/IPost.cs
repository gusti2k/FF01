﻿using FF01.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FF01.Data
{
    public interface IPost
    {
        Post GetByID(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByForum(int id);

        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        

        //Task AddReply(PostReply reply);
    }
}
