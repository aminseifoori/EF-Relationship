using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relationship.Models
{
    public class Award
    {
        public string ID { get; set; }
        public string AwardName { get; set; }
        public string ActorID { get; set; }
        [ForeignKey(nameof(ActorID))]
        public virtual Actor Actor { get; set; }
    }
}
