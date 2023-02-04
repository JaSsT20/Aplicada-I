using System.ComponentModel.DataAnnotations;

public class Loans
{
    [Key]
    public int loanID { get; set; }
    public DateTime date { get; set; }

    public DateTime expires { get; set; }

    public int personID { get; set; }

    public int concept { get; set; }

    public float amount { get; set; }

    public int balance { get; set; }
}