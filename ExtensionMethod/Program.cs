Policy policy = new Policy
{
    id = 1,
    policyNumber = "POL12345678",
    policyHolderName = "parikshit shelorkar",
    premium = 10000,
    startDate = DateTime.Today.AddMonths(-6),
    endDate = DateTime.Today.AddDays(20),
    isActive = true
};

Console.WriteLine(policy.IsValid());
Console.WriteLine(policy.DaysRemaining());
Console.WriteLine(policy.GetSummary());
