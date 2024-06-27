using Microsoft.EntityFrameworkCore;

namespace ExamWed_DuongTruongPhuocThinh
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> ops) : base(ops)
        {
        }
        public DbSet<ExamDB> ExamDB { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ExamDB>().HasData(
            new ExamDB { Id = 1, Title = " CD Nỗi buồn gác trọ", Author = "Việt Nam", Price = 105.000, Quantity = 20 },
            new ExamDB { Id = 2, Title = "CD Bài tình ca đêm", Author = "Việt Nam", Price = 250.000, Quantity = 15 },
            new ExamDB { Id = 3, Title = "CD BABYMONSTER", Author = "Nước Ngoài", Price = 230.000, Quantity = 10 },
            new ExamDB { Id = 4, Title = " CD Chuyện chúng mình", Author = "Việt Nam", Price = 150.000, Quantity = 30 },
            new ExamDB { Id = 5, Title = "CD Today's US-UK Hit", Author = "Nước Ngoài", Price = 27.000, Quantity = 10 },
            new ExamDB { Id = 6, Title = "CD Đoá hồng nhạc Việt", Author = "Việt Nam", Price = 220.000, Quantity = 40 }
            );
        }
    }
}