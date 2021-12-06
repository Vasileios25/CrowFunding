using CrowFunding.Domain;
using CrowFunding.Dto;
using CrowFunding.Services;
using CrowFunding.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Service
{
    public class ProjectUserService : IProjectUser
    {
        private readonly CrmDbContext _db;

        public ProjectUserService (CrmDbContext user)
        {
            _db = user;
        }
        public async Task<UserDto> AddUser(UserDto dto)
        {
            User user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Password = dto.Password
            };
            _db.User.Add(user);
            await _db.SaveChangesAsync();
            return user.Convert();
        }

        public async Task<bool> Delete(int id)
        {
            User user = await _db.User.SingleOrDefaultAsync(b => b.Id == id);
            if (user is null) return false;

            _db.Remove(user);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<List<UserDto>> GetAllUser(bool includeBooks)
        {
            IQueryable<User> usersQuery = _db.Authors;
            if (includeBooks)
            {
                usersQuery = _db.User.Include(a => a.ProjectPages);
            }

            return await usersQuery.Select(a => a.Convert()).ToListAsync();
        }

        public async Task<UserDto> GetUser(int id, bool includeBooks)
        {
            var UserQuery = _db.User.Where(a => a.Id == id);
            if (includeBooks)
            {
                UserQuery = UserQuery.Include(a => a.Books);
            }

            var user = await UserQuery.SingleOrDefaultAsync();
            return user.Convert();
        }

        public Task<UserDto> Replace(int bookId, UserDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDto>> Search(string firstName, string lastName, bool includeprojects)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> Update(int userId, UserDto dto)
        {
            User author = await _db.User
                .SingleOrDefaultAsync(a => a.Id == userId);

            if (author is null) throw new NotFoundException("The author id is invalid or has been removed.");

            if (dto.FirstName is not null) author.FirstName = dto.FirstName;
            if (dto.LastName is not null) author.LastName = dto.LastName;

            await _db.SaveChangesAsync();

            return author.Convert();
        }
    }
}
