﻿using FF01.Data;
using FF01.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF01.Service
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;

        public PostService( ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(Post post)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetByID(int id)
        {
            return _context.Posts.Where(p => p.Id == id)
                .Include(post => post.User)
                .Include(post => post.Replies).ThenInclude(r => r.User)
                .Include(post => post.Forum)
                .First();
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            var posts = _context.Forums.Where(f => f.Id == id).First()
                .Posts;

            return posts;
        }
    }
}
