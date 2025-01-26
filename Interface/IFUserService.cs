using FreeLance.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeLance.Interface
{
    public interface IFUserService
    {

        IEnumerable<FreelanceUser> getAllFreelancerList();
        FreelanceUser getFreelancerById(Guid id);
        void registerFreelancer(FreelanceUser AddFUser);
        void updateFreelancer(Guid id, FreelanceUser updatedFUser);
        void deleteFreelancer(Guid id);
        IEnumerable<FreelanceUser> searchFreelancers(string keyword);
        void archiveFreelancer(Guid id);
        void unarchiveFreelancer(Guid id);
    }
}
