using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id= 1,
                    Name = "India",
                    ShortName = "IN"
                },
                 new Country{
                Id = 2,
                    Name = "Canada",
                    ShortName = "CN"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Lemon Tree",
                    Address = "Bangalore",
                    Rating = 4,
                    CountryId = 1
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Taj",
                     Address = "Canada",
                     Rating = 4,
                     CountryId = 2
                 }
                );
        }
    }
}
