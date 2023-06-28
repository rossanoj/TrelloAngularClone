using System.ComponentModel.DataAnnotations;

namespace TareasNetApi.models;

public class Categoria
{
    [Key]
    public Guid CategoriaID { get; set; }
    [Required]
    [MaxLength(40)]
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public virtual ICollection<Tarea> Tareas { get; set; }
}