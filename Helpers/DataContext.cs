using CvApi.Entities;
using CvApi.Services;
using Microsoft.EntityFrameworkCore;

namespace CvApi.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}