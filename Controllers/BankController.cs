using Free4u_Mini_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace Free4u_Mini_App.Controllers
{
    public class BankController : Controller
    {
        private readonly string _connectionString;

        // Hàm khởi tạo để lấy chuỗi kết nối từ appsettings.json
        public BankController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Chỉ giữ lại MỘT hàm Index duy nhất
        public IActionResult Index()
        {
            // Kết nối SQLite bằng Dapper
            using var connection = new SqliteConnection(_connectionString);

            // Truy vấn trực tiếp từ View trong SQLite
            var data = connection.Query<Transactions>("SELECT * FROM v_TransactionSummaryBank").ToList();

            // Truyền dữ liệu sang file View (Index.cshtml)
            return View(data);
        }

        [HttpPost]
        public IActionResult BatchPost([FromBody] List<string> ids)
        {
            if (ids == null || !ids.Any())
            {
                return Json(new { success = false, message = "Không có dữ liệu được chọn." });
            }

            try
            {
                // TODO: Viết logic cập nhật trạng thái "Đã ghi sổ" vào Database cho các giao dịch có ID trong danh sách `ids`
                // Ví dụ:
                // var transactions = _context.Transactions.Where(x => ids.Contains(x.TransactionID)).ToList();
                // foreach(var item in transactions) { item.IsPosted = true; }
                // _context.SaveChanges();

                return Json(new { success = true, message = $"Đã ghi sổ thành công {ids.Count} giao dịch!" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
