using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baithi_HAH.Models
{
    public class HAHCau3
    {
        [Key]
        [Display(Name ="Mã sinh viên")]
        public string Masinhvien { get; set;}
        [Display(Name ="Họ tên sinh viên")]
        public string Hoten { get; set;}
        [Display(Name ="Năm sinh sinh viên")]
        public string Namsinh { get; set;}
    }
}