using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class PaymentsDetail
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("paymentID")]
    public int PaymentID { get; set; }
    public int LoanID { get; set; }
    public float AmountPaid { get; set; }
}