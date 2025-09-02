using System;
using System.ComponentModel.DataAnnotations;

namespace razordb.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la tarea es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        [Display(Name = "Nombre de la Tarea")]
        public string nombreTarea { get; set; }

        [Required(ErrorMessage = "La fecha de vencimiento es obligatoria")]
        [DataType(DataType.DateTime)]
        [FutureDate(ErrorMessage = "La fecha de vencimiento debe ser igual o posterior a la fecha actual")]
        [Display(Name = "Fecha de Vencimiento")]
        public DateTime fechaVencimiento { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Required(ErrorMessage = "El ID de usuario es obligatorio")]
        [Display(Name = "Usuario")]
        public int idUsuario { get; set; }
    }
}