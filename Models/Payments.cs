using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payments
{
    [Key]
    public int paymentID {get; set;}
    public DateTime date { get; set; }
    public int personID { get; set; }
    public string? concept { get; set; }
    public float amount { get; set; }
    public PaymentsDetail PaymentsDetail { get; set; } = new PaymentsDetail();
}