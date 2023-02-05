using System.ComponentModel.DataAnnotations;

public class PaymentsDetail
{
    [Key]
    public int id { get; set; }
    
    public int paymentID { get; set; }

    public int loanID { get; set; }

    public float amountPaid { get; set; }
}