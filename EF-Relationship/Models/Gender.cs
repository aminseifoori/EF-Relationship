using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relationship.Models
{
    public class Gender
    {
        [Key]
        public string ID { get; set; }
        public string GenderType { get; set; }
        public virtual Actor Actor { get; set; }
    }
}
