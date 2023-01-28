using System.ComponentModel.DataAnnotations;

public class Ocupations
{
    [Key]
    public int OcupationId { get; set; }

    [Required(ErrorMessage = "La descripcion es requerida.")]
}