using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume_Asp.Models
{
    public class ResumeSection
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        [ForeignKey("Resume")]
        public int ResumeId { get; set; }

        public virtual Resume Resume { get; set; } = default!;
    }
}
