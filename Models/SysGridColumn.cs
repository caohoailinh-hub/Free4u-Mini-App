using System.ComponentModel.DataAnnotations;

namespace Free4u_Mini_App.Models
{
    public class SysGridColumn
    {
        [Key] // <--- Khai báo đây là khóa chính
        public int ID { get; set; }        
        public string? GridCode { get; set; }     // Thêm dấu ?
        public string? ColumnName { get; set; }   // Thêm dấu ?
        public string? HeaderTitle { get; set; }  // Thêm dấu ?
        public int SortOrder { get; set; }
        public bool IsVisible { get; set; }
    }
}
