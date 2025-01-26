using FreeLance.DBContext;
using FreeLance.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeLance.Service
{
    public class FUserService
    {
        private readonly FreelanceDbContext _context;
        
        public FUserService(FreelanceDbContext context)
        {
            _context = context;
        }

        public IEnumerable<FreelanceUser> getAllFreelancerList()
        {
            return _context.FreelanceUsers
                .Include(f => f.USkillsets)
                .Include(f => f.UHobbies)
                .Where(f => !f.IsArchived)
                .ToList();
        }

        public FreelanceUser GetFreelancerById(Guid id)
        {
            return _context.FreelanceUsers
                .Include(f => f.USkillsets)
                .Include(f => f.UHobbies)
                .FirstOrDefault(f => f.UId == id);
        }

        public void registerFreelancer(FreelanceUser freelancer)
        {
            _context.FreelanceUsers.Add(freelancer);
            _context.SaveChanges();
        }

        public void updateFreelancer(Guid id, FreelanceUser updatedFUser)
        {
            var freelancer = _context.FreelanceUsers.Include(f => f.USkillsets).Include(f => f.UHobbies).FirstOrDefault(f => f.UId == id);

            if (freelancer == null) return;

            freelancer.Username = updatedFUser.Username;
            freelancer.Email = updatedFUser.Email;
            freelancer.PhoneNumber = updatedFUser.PhoneNumber;
            freelancer.USkillsets = updatedFUser.USkillsets;
            freelancer.UHobbies = updatedFUser.UHobbies;

            _context.SaveChanges();
        }

        public void DeleteFreelancer(Guid id)
        {
            var freelancer = _context.FreelanceUsers.Find(id);
            if (freelancer == null) return;

            _context.FreelanceUsers.Remove(freelancer);
            _context.SaveChanges();
        }

        public IEnumerable<FreelanceUser> SearchFreelancers(string keyword)
        {
            return _context.FreelanceUsers
                .Where(f => f.Username.Contains(keyword) || f.Email.Contains(keyword))
                .Include(f => f.USkillsets)
                .Include(f => f.UHobbies)
                .ToList();
        }

        public void ArchiveFreelancer(Guid id)
        {
            var freelancer = _context.FreelanceUsers.Find(id);
            if (freelancer == null) return;

            freelancer.IsArchived = true;
            _context.SaveChanges();
        }

        public void UnarchiveFreelancer(Guid id)
        {
            var freelancer = _context.FreelanceUsers.Find(id);
            if (freelancer == null) return;

            freelancer.IsArchived = false;
            _context.SaveChanges();
        }
    }
}
