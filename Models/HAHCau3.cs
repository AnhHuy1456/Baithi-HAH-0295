using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baithi_HAH.Models
{
    public class HAHCau3
    {
        [Key]
        public string Masinhvien { get; set;}
        public string Hoten { get; set;}
        public string Namsinh { get; set;}
    }
}