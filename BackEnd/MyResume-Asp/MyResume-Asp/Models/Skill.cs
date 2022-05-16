using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume_Asp.Models
{
    public class Skill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NameSkill { get; set; }
        public int Learned { get; set; }

        [ForeignKey("MySkills")]
        public int IdSkillSet { get; set; }
        public virtual MySkills MySkills { get; set; }
    }
}
