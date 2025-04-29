using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Models;
using System.Collections.Generic;

namespace CinemaWebApp.Data
{
    public class CinemaContext : DbContext  
    {
        public CinemaContext(DbContextOptions<CinemaContext> options)
            : base(options)
        {
        }

        public DbSet<Hall> Halls { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
