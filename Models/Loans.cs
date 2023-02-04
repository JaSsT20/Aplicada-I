using System.ComponentModel.DataAnnotations;

public class Loans
{
    [Key]
    public int loanID { get; set; }
    public DateTime date { get; set; }

    public DateTime expires { get; set; }

    public int personID { get; set; }

    public string? concept { get; set; }

    public float amount { get; set; }

    public float balance { get; set; }
}