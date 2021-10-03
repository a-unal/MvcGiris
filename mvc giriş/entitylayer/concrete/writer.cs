using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
   public class writer
    {
        [Key]
        public int WriterID { get; set; }
        
        [StringLength(50)]
        public string WriterName { get; set; }
        
        [StringLength(50)]
        public string WriterSurName { get; set; }

        [StringLength(50)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }
        
        [StringLength(20)]
        public string WriterPassword { get; set; }

        public ICollection<heading> Headings { get; set; }
        public ICollection<content> Contents { get; set; }


    }
}
