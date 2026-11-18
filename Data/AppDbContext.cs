using Microsoft.EntityFrameworkCore;
using Free4u_Mini_App.Models;
namespace Free4u_Mini_App.Data
{
    public class AppDbContext : DbContext
    {
        // Khai báo DbSet để truy vấn dữ liệu từ View
        public DbSet<Transactions> Transactions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình cho View v_TransactionSummaryCash
            modelBuilder.Entity<Transactions>(entity =>
            {
                // 1. Khai báo đây là Keyless Entity (vì View trong CSDL thường không có khóa chính)
                entity.HasNoKey();

                // 2. Ánh xạ trực tiếp tới tên View trong SQLite
                entity.ToView("v_TransactionSummaryCash");
                // Hoặc bạn có thể dùng: entity.ToTable("v_TransactionSummaryCash");
            });
        }

    }

}
