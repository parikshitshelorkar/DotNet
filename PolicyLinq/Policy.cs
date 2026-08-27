

public class Policy
{
    public int Id { get; set; }
    public string PolicyNumber { get; set; } = "";
    public string PolicyHolderName { get; set; } = "";
    public int Premium { get; set; }
    public int SumAssured { get; set; }
    public bool Status { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int CustomerId { get; set; }
}