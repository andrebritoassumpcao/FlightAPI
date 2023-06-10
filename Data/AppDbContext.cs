using System;
using FlightAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightAPI.Data {
    public class AppDbContext : DbContext {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=app.db;Cache=Shared");
        }
    }
}
