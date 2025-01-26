using FreeLance.Interface;
using FreeLance.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FreeLance.Controllers
{
    public class FUserController : Controller
    {
        private readonly IFUserService _service;

        public FUserController(IFUserService service)
        {
            _service = service;
        }

        [HttpGet("GetFreeLancerUserList")]
        public IActionResult GetAllFUserList()
        {
            return Ok(_service.getAllFreelancerList());
        }

        [HttpGet("GetFreeLancerUserList/{id}")]
        public IActionResult GetFUserById(Guid id)
        {
            var fuser = _service.getFreelancerById(id);
            if (fuser == null) return NotFound();

            return Ok(fuser);
        }

        [HttpGet("Register")]
        public IActionResult RegisterFUser(FreelanceUser fUser)
        {
            _service.registerFreelancer(fUser);
            return CreatedAtAction(nameof(GetFUserById), new { id = fUser.UId }, fUser);
        }

        [HttpPut("FreeLancerUserUpdate/{id}")]
        public IActionResult UpdateFreelancer(Guid id, FreelanceUser updatedFUser)
        {
            _service.updateFreelancer(id, updatedFUser);
            return NoContent();
        }

        [HttpDelete("FreeLancerUserDelete/{id}")]
        public IActionResult DeleteFUser(Guid id)
        {
            _service.deleteFreelancer(id);
            return NoContent();
        }

        [HttpGet("FreeLancerUserSearch")]
        public IActionResult SearchFUser(string keyword)
        {
            return Ok(_service.searchFreelancers(keyword));
        }

        [HttpPatch("Archive/{id}")]
        public IActionResult ArchiveFUser(Guid id)
        {
            _service.archiveFreelancer(id);
            return NoContent();
        }

        [HttpPatch("Unarchive/{id}")]
        public IActionResult UnarchiveFUser(Guid id)
        {
            _service.unarchiveFreelancer(id);
            return NoContent();
        }
    }
}
