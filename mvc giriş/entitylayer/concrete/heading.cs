﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
   public class heading
    {
        [Key]
        public int HeadingID { get; set; }
       
        [StringLength(50)]
        public string HeadingName { get; set; }
      
        public DateTime HeadingDate { get; set; }


        public int CategoryID { get; set; }
        public virtual category Category  { get; set; }


        public int WriterID { get; set; }
        public virtual writer Writer { get; set; }

        public ICollection<content> Contents { get; set; }
    }
}
