using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payments
{
    [Key]
    public int paymentID {get; set;}

    [Required(ErrorMessage = "La fehca es obligatoria.")]
    public DateTime date { get; set; } = DateTime.Today;

    [Range(0, int.MaxValue, ErrorMessage = "El ID persona es obligatorio.")]
    public int personID { get; set; }
    public string? concept { get; set; }

    [Range(0, float.MaxValue, ErrorMessage = "La cantidad es obligatoria y debe ser mayor que cero.")]
    public float amount { get; set; }
    public List<PaymentsDetail> PaymentsDetail { get; set; } = new List<PaymentsDetail>();
}