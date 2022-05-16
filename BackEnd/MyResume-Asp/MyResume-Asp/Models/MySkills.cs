using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume_Asp.Models
{
    public class MySkills
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Info { get; set; }

        public ICollection<Skill> SkillsList { get; set; }

        public MySkills()
        {
            SkillsList = new HashSet<Skill>();
        }
    }
}
