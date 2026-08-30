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
        Console.WriteLine("Policies sorted by Premium in descending order:" + policiesByPremium);

        var policyNumbers = policies.Select(p => p.PolicyNumber);
        Console.WriteLine("Policy Numbers: " + string.Join(", ", policyNumbers));//join keyword is used to join the elements of a collection into a single string, with a specified separator.

        bool hasPolicy = policies.Any(p => p.CustomerId == 101);
        Console.WriteLine("Does the customer with ID 101 have any policies? " + hasPolicy);

        var policy = policies.FirstOrDefault(p => p.PolicyNumber == "POL1001");
        Console.WriteLine("Policy with number POL1001: " + policies);

        var customerPolicies = policies.Where(p => p.CustomerId == 101);//Selecting specific properties from the policies and creating a new anonymous type
        Console.WriteLine("Policies for customer with ID 101: " + customerPolicies);

        var policySummary = policies.Select(p => new { p.PolicyNumber, p.Premium, p.Status }).ToList();
        Console.WriteLine("Policy Summary: " + policySummary);

        var result = policies
        .Where(p => p.IsActive())
        .Where(p => p.SumAssured > 1000000)
        .OrderByDescending(p => p.Premium)
        .ToList();
        Console.WriteLine("Active policies with Sum Assured greater than 1,000,000 sorted by Premium in descending order: " + result);

        List<Claim> claims = new List<Claim>
        {
        new Claim { Amount = 50000, Status = "Pending" },
        new Claim { Amount = 100000, Status = "Approved" },
        new Claim { Amount = 75000, Status = "Pending" },
        new Claim { Amount = 20000, Status = "Rejected" },
        new Claim { Amount = 150000, Status = "Pending" }
        };

        List<Claim> pendingClaims = claims
        .Where(c => c.Status == "Pending")
        .Where(c => c.Amount > 50000)
        .OrderByDescending(c => c.Amount)
        .ToList();


    }



    // private List<Premium> premiums = new();
    // decimal totalPremium = premiums.Sum(p => p.Amount);
    // decimal averagePremium = premiums.Average(p => p.Amount);
    // decimal highestPremium = premiums.Max(p => p.Amount);
    // int totalPolicies = policies.Count();


    
};