using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class User
    {
        [Required] //Verificar que se importó using System.ComponentModel.DataAnnotations;
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Id { get; set; } // Será la llave primaria
        public string Name { get; set; }
        public ICollection<User>? Users { get; set; } = default!; // Propiedad de navegación
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
