using System.ComponentModel.DataAnnotations;
namespace BD.Modelos
{
    public class Multa
    {

        [Required(ErrorMessage = "El id es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de creación es requerida")]
        public DateTime? FechaCreacion { get; set; }

        [Required(ErrorMessage = "El estado de completado es requerido")]
        public bool Completado { get; set; }

        [Required(ErrorMessage = "La fecha de pago es requerida")]
        public DateTime? FechaPago { get; set; }

        [Required(ErrorMessage = "El monto es requerido")]
        public double Monto { get; set; }

        [Required(ErrorMessage = "El id de préstamo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un préstamo válido")]
        public int PrestamoId { get; set; }
        virtual public Prestamo? Prestamo { get; set; }

    }
}
