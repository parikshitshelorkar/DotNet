public class Policy
{
    public int id {get; set;}
    public string policyNumber {get; set;}
    public string policyHolderName {get; set;} = "";
    public int premium {get; set;}
    public bool Status {get; set;}
    public DateTime startDate {get; set;}
    public DateTime endDate {get; set;}

}