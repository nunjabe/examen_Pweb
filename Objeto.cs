using System.ComponentModel.DataAnnotations;

namespace Tarea.Models
{
    public class Objeto
    {
        // Propiedad para identificar el producto de forma única
        public int Id { get; set; }

        [Required(ErrorMessage = "El número de inventario es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un número entero positivo.")]
        public int? NumeroInventario { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [MaxLength(200, ErrorMessage = "El nombre no puede exceder 200 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El departamento es obligatorio.")]
        [RegularExpression("Frutas|Verduras|Lácteos",
            ErrorMessage = "El departamento debe ser 'Frutas', 'Verduras' o 'Lácteos'.")]
        public string? Departamento { get; set; }
    }
}
