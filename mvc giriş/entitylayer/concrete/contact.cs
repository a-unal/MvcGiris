using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
    public class contact
    {
        [Key]
        public int ContactID { get; set; }
       
        [StringLength(50)]
        public string Username { get; set; }
        
        [StringLength(50)]
        public string UserMail { get; set; }
        
        [StringLength(50)]
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
