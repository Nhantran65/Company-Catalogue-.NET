﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace company_catalogue_api.Models
{ public class BookingDoctorContext : DbContext
{
    public BookingDoctorContext(DbContextOptions<BookingDoctorContext> options)
        : base(options)
    {
            Users = Set<User>();
            Roles = Set<Role>();
            Companies = Set<Company>();
    }

    // DbSet cho các đối tượng trong cơ sở dữ liệu
        public DbSet<Role> Roles { get; set; } // Khởi tạo hoặc làm cho Users có thể là null
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
} 
}
