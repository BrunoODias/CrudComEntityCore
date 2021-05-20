
using System.ComponentModel.DataAnnotations;

namespace CrudComEntityCore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Autores")]
        [Required]
        public string Authors { get; set; }

        [Display(Name = "Gênero")]
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Quantidade de páginas")]
        [Required]
        public int PageCount { get; set; }
    }
}
