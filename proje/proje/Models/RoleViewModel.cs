using System.ComponentModel.DataAnnotations;

namespace proje.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="lütfen rol giriniz")]
        public string name { get; set; }
    }
}
