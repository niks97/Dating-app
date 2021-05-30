using Datingapp_Server.DTOs;
using Datingapp_Server.Entities;
using Datingapp_Server.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);

        Task<AppUser> GetUserWithLikes(int userId);

        Task<PagedList<LikedDto>> GetUserLikes(LikesParams likesParams);
    }
}
