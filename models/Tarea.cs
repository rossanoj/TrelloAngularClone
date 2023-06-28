using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TareasNetApi.Models;

public class Tarea {
    [Key]
    public Guid TareaID { get; set; }
    [ForeignKey("CategoriaID")]
    public Guid CategoriaID { get; set; }
    [Required]
    [MaxLength(60)]
    public string Titulo { get; set; }
    public string? Descripcion { get; set; }
    public Prioridad PrioridadTarea { get; set; }
    public DateTime FechaCreacion { get; set; }
    public virtual Categoria Categorias { get; set; }
    [NotMapped]
    public string Resumen { get; set; }
}

public enum Prioridad
{
    Baja,
    Media,
    Alta
}