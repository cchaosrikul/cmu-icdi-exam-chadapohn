using cmu_icdi_exam_chadapohn.Models;
using Microsoft.EntityFrameworkCore;

namespace cmu_icdi_exam_chadapohn.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Blogs> Blogs { get; set; }
        
    }   
}