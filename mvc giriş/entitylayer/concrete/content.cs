using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
   public class content
    { 
    
        [Key]
        public int ContentID { get; set; }
        
        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; }
        public virtual heading Heading { get; set; }


        public int? WriterID { get; set; }
        public virtual writer Writer { get; set; }



    }
}
