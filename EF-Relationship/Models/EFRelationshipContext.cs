using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relationship.Models
{
    public class EFRelationshipContext : DbContext
    {
        public EFRelationshipContext(DbContextOptions<EFRelationshipContext> options) : base(options)
        {

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Award> Awards { get; set; }
    }
}
