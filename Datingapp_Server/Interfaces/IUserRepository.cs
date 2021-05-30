using Datingapp_Server.DTOs;
using Datingapp_Server.Entities;
using Datingapp_Server.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.Interfaces
{
   public interface IUserRepository
    {
        void Update(AppUser user);

        Task<bool> SaveAllSync();

        Task<IEnumerable<AppUser>> GetUsersAsync();

        Task<AppUser> GetUserByIdAsync(int id);

        Task<AppUser> GetUserByUsernameAsync(String username);

        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);

        Task<MemberDto> GetMemberAsync(String username);

  
    }
}
