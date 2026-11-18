using System.ComponentModel.DataAnnotations;

namespace Free4u_Mini_App.Models
{
    public class SysMenu
    {
        [Key] // <--- Khai báo đây là khóa chính
        public int MenuID { get; set; }
        public string? ModuleCode { get; set; }  // Thêm dấu ?
        public string? MenuName { get; set; }  // Thêm dấu ?
        public string? ControllerName { get; set; } // Thêm dấu ?
        public string? ActionName { get; set; } // Thêm dấu ?
        public string? DataFilter { get; set; } // Thêm dấu ?
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
    }
}
