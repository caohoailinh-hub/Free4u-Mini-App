using Free4u_Mini_App.Models;
using Free4u_Mini_App.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Free4u_Mini_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> Index()
        {
            // Lấy dữ liệu từ SQLite
            List<Transactions> itemList = await _context.Transactions.ToListAsync();

            // Trỏ trực tiếp sang file home.cshtml
            return View(itemList);
        }
        // 2. Hiển thị Form Thêm mới (GET)
        public IActionResult Create()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
