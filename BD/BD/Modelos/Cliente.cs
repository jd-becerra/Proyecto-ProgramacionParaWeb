using System.ComponentModel.DataAnnotations;
namespace BD.Modelos
{
    public class Cliente
    {
        [Required(ErrorMessage = "El id es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        [StringLength(100, ErrorMessage = "El correo no puede tener más de 100 caracteres")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El número de teléfono es requerido")]
        [Phone(ErrorMessage = "El número de teléfono no es válido")]
        public string? Teléfono { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")]
        public string? Dirección { get; set; }

        //Prestamos
        public ICollection<Prestamo>? Prestamos { get; set; }
    }
}
