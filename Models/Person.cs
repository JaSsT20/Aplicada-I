using System.ComponentModel.DataAnnotations;

public class Person
{
    [Key]
    public int personID { get; set; }

    [Required(ErrorMessage = "La descripcion es requerida.")]
    public string? name { get; set; }

    public string? phoneNumber { get; set; }

    public string? cellphoneNumber { get; set; }

    public string? email { get; set; }

    public string? direction { get; set; }

    public string? dateBirth { get; set; }
    public int occupationID { get; set; }

}