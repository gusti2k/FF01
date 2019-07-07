using FF01.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FF01.Data
{
    public interface IForum
    {
        Forum GetByID(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int ForumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newTitle);

    }
}