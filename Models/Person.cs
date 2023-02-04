using System.ComponentModel.DataAnnotations;

public class Person
{
    [Key]
    public int personID { get; set; }

    [Required(ErrorMessage = "El nombre es requerido.")]
    public string? name { get; set; }

    public string? phoneNumber { get; set; }

    public string? cellphoneNumber { get; set; }

    public string? email { get; set; }

    public float balance { get; set; }

    public string? direction { get; set; }

    public DateTime dateBirth { get; set; }
    [Required(ErrorMessage = "Seleccione una ocupación.")]
    public int occupationID { get; set; }

}