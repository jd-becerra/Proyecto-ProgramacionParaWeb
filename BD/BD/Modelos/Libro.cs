using System.ComponentModel.DataAnnotations;
namespace BD.Modelos
{
    public class Libro
    {
        [Required(ErrorMessage = "El id es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es requerido")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "El género del libro es requerido")]
        public string? Genero { get; set; }

        [Required(ErrorMessage = "El autor es requerido")]
        public string? Autor { get; set; }

        //año de publicación
        [Required(ErrorMessage = "El año de publicación es requerido")]
        public int Año { get; set; }

        [Required(ErrorMessage = "El número de edición es requerido")]
        public int Edicion { get; set; }

        [Required(ErrorMessage = "El ISBN es requerido")]
        public string? ISBN { get; set; }

        [Required(ErrorMessage = "La cantidad de libros disponibles es requerida")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La editorial es requerida")]
        public string? Editorial { get; set; }

        //Préstamos
        public ICollection<Prestamo>? Prestamos { get; set; }
    }
}
