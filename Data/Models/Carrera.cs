
using System.ComponentModel.DataAnnotations;

namespace Estudiantes20111179.Data.Models;

public class Carrera
{
    public Carrera()
    {
        
    }
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
}