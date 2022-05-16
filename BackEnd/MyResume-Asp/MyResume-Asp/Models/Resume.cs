using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume_Asp.Models
{
    public class Resume
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Dscription { get; set; }

        public virtual ICollection<ResumeSection> Resumesec { get; set; }

        public Resume()
        {
            Resumesec = new HashSet<ResumeSection>();
        }
    }
}
