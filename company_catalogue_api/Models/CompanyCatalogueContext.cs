using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace company_catalogue_api.Models
{ public class BookingDoctorContext : DbContext
{
    public BookingDoctorContext(DbContextOptions<BookingDoctorContext> options)
        : base(options)
    {
        Roles = Set<Role>();
    }

    // DbSet cho các đối tượng trong cơ sở dữ liệu
    public DbSet<Role> Roles { get; set; } // Khởi tạo hoặc làm cho Users có thể là null
} 
}
