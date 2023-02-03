using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeanstalkNet.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BeanstalkNet.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var now = DateTime.UtcNow;

            var notes = new List<Note> {
                new Note {
                    Id = 1,
                    Content = "Finish Youtube video",
                    UpdatedOn = now,
                    CreatedOn = now
                },
                new Note {
                    Id = 2,
                    Content = "Go to gym",
                    UpdatedOn = now,
                    CreatedOn = now
                },
                new Note {
                    Id = 3,
                    Content = "Go to grocery",
                    UpdatedOn = now,
                    CreatedOn = now
                },
            };

            modelBuilder.Entity<Note>().HasData(notes);
        }
        public DbSet<Note> Notes { get; set; }
    }
}