using AutoMapper;
using Datingapp_Server.Data;
using Datingapp_Server.DTOs;
using Datingapp_Server.Entities;
using Datingapp_Server.Interfaces;
using Datingapp_Server.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datingapp_Server.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly DataContext _context;
        public AccountController(DataContext context,ITokenService tokenService,IMapper mapper)
        {
            _mapper = mapper;
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {

            if (await UserExists(registerDto.Username))

                return BadRequest("Username is Taken");

            var user = _mapper.Map<AppUser>(registerDto);
            
            using var hmac = new HMACSHA512();


            user.UserName = registerDto.Username.ToLower();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password));
               user.PasswordSalt = hmac.Key;
            

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return new UserDto
            {
                Username=user.UserName,
                Token=_tokenService.CreateToken(user),
                KnownAs=user.KnownAs,
                Gender=user.Gender
               

            };
        }
     

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _context.Users
            .SingleOrDefaultAsync(x => x.UserName == loginDto.Username);

            if (user == null) return Unauthorized("Invalid UserName");

            using var hmac = new HMACSHA512(user.PasswordSalt);

            var ComputeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < ComputeHash.Length; i++)
            {
                if (ComputeHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid Password");
            }

            return new UserDto
            {
                Username = user.UserName,
                Token = _tokenService.CreateToken(user),
                //PhotoUrl = user.Photos.FirstOrDefault(x => x.IsMain)?.Url,
                //KnownAs = user.KnownAs,
                //Gender = user.Gender

            };
           
        }


        private async Task<bool> UserExists(String username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username.ToLower());
        }
       
    }
}
