public static class PolicyExtension
{
    public static bool IsActive(this Policy policy)
    {
        return policy.Status;
    }
}