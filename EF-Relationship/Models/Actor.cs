using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relationship.Models
{
    public class Actor
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        [Required]
        public string GenderID { get; set; }
        [ForeignKey(nameof(GenderID))]
        public virtual Gender Gender { set; get; }
        public virtual ICollection<Award> Awards { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
}
