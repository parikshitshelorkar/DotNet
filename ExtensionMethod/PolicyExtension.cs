public static class PolicyExtensions
{
    public static bool IsValid(this Policy policy)
    {
        // endDate > today
        DateTime today = DateTime.Today;

        return policy.Status && policy.startDate <= today && policy.endDate >= today;

    }

    public static int DaysRemaining(this Policy policy)
    {
        int days = (policy.endDate.Date - DateTime.Today).Days;
        return days;
    }

    // public static int CalculatePremium(this Policy policy, int yearly)
    // {
    //     return yearly * 0.5;
    // }
    public static string GetSummary(this Policy policy)
    {
        return
            $"Policy: {policy.policyNumber}\n" +
            $"Holder: {policy.policyHolderName}\n" +
            $"Premium: ₹{policy.premium}\n" +
            $"Status: {(policy.IsValid() ? "Valid" : "Invalid")}";
    }

    public static bool IsActive(this Policy policy)
    {
        return policy.Status == true;
    }

}