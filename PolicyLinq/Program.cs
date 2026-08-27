using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<Policy> GetPolicies()
    {
        List<Policy> policies = new List<Policy>
        {
            new Policy
            {
                Id = 1,
                PolicyNumber = "POL-1001",
                PolicyHolderName = "Rahul Sharma",
                Premium = 12000,
                Status = true,
                StartDate = new DateTime(2026, 1, 1),
                EndDate = new DateTime(2026, 12, 31)
            },

            new Policy
            {
                Id = 2,
                PolicyNumber = "POL-1002",
                PolicyHolderName = "Priya Patil",
                Premium = 18000,
                Status = true,
                StartDate = new DateTime(2026, 2, 1),
                EndDate = new DateTime(2027, 1, 31)
            },

            new Policy
            {
                Id = 3,
                PolicyNumber = "POL-1003",
                PolicyHolderName = "Amit Kulkarni",
                Premium = 25000,
                Status = false,
                StartDate = new DateTime(2025, 1, 1),
                EndDate = new DateTime(2025, 12, 31)
            }
        };

        return policies;
    }


    public static void Main()
    {
        List<Policy> policies = GetPolicies();

        List<Policy> activePolicies = policies
            .Where(p => p.Status)
            .ToList();

        foreach (Policy poli in activePolicies)
        {
            Console.WriteLine(poli.PolicyHolderName);
        }

        var policiesByPremium = policies.OrderByDescending(p => p.Premium);
        var policyNumbers = policies.Select(p => p.PolicyNumber);
        bool hasPolicy = policies.Any(p => p.CustomerId == 101);
        var policy = policies.FirstOrDefault(p => p.PolicyNumber == "POL1001");
        var customerPolicies = policies.Where(p => p.CustomerId == 101);
        var policySummary = policies.Select(p => new { p.PolicyNumber, p.Premium, p.IsActive }).ToList();

        var result = policies
    .Where(p => p.IsActive())
    .Where(p => p.SumAssured > 1000000)
    .OrderByDescending(p => p.Premium)
    .ToList();


        Console.WriteLine(policiesByPremium);
        Console.WriteLine(policyNumbers);
        Console.WriteLine(policy);
        Console.WriteLine();
    }
    


    List<Claim> claims = new List<Claim>
    {
        new Claim { Amount = 50000, Status = "Pending" },
        new Claim { Amount = 100000, Status = "Approved" },
        new Claim { Amount = 75000, Status = "Pending" },
        new Claim { Amount = 20000, Status = "Rejected" },
        new Claim { Amount = 150000, Status = "Pending" }
    };
    // var pendingClaims = claims
    // .Where(c => c.Status == "Pending")
    // .Where(c => c.Amount > 50000)
    // .OrderByDescending(c => c.Amount)
    // .ToList();

    private static readonly List<Premium> premiums = new();

    decimal totalPremium = premiums.Sum(p => p.Amount);
    decimal averagePremium = premiums.Average(p => p.Amount);
    decimal highestPremium = premiums.Max(p => p.Amount);
    // int totalPolicies = policies.Count();
};