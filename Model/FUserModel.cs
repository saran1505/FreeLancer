using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreeLance.Model
{
    public class FreelanceUser
    {
            [Key]
            public Guid UId { get; set; } = Guid.NewGuid();
            public string Username { get; set; }
            public string Fullname { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public ICollection<USkillset> USkillsets { get; set; }
            public ICollection<UHobby> UHobbies { get; set; }
            public bool IsArchived { get; set; } = false;
    }

        public class USkillset
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Guid UId { get; set; }
        }

        public class UHobby
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Guid UId { get; set; }
        }
    }
