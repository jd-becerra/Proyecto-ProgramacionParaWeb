using System.ComponentModel.DataAnnotations;
namespace BD.Modelos
{
    public class Prestamo
    {
        //campos: id(int), fecha de préstamo(string), fecha de entrega(string), estado de completado(bool), duracion en dias (int), id de cliente(int), id de libro(int)

        [Required(ErrorMessage = "El id es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de préstamo es requerida")]
        public DateTime? FechaPrestamo { get; set; }

        [Required(ErrorMessage = "La fecha de entrega es requerida")]
        public DateTime? FechaEntrega { get; set; }

        [Required(ErrorMessage = "El estado de completado es requerido")]
        public bool Completado { get; set; }

        [Required(ErrorMessage = "La duración en días es requerida")]
        public int Duracion { get; set; }

        [Required(ErrorMessage = "El id de cliente es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un cliente válido")]
        public int ClienteId { get; set; }
        virtual public Cliente? Cliente { get; set; }

        [Required(ErrorMessage = "El id de libro es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un libro válido")]
        public int LibroId { get; set; }
        virtual public Libro? Libro { get; set; }

        //Multas
        public ICollection<Multa>? Multas { get; set; }
    }
}
