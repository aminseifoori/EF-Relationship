using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relationship.Models
{
    public class Movie
    {
        public string ID { get; set; }
        public string MovieName { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
