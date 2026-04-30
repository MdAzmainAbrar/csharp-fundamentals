using Project20;

public static class SupervisorAI
{
    public static string GetLineStatus(ProductionLine line)
    {
        double efficiency = (double)line.ActualOutput / line.Target;

        return efficiency switch
        {
            >= 0.95 => "Optimal: Maintain current pace.",
            >= 0.80 => "Warning: Minor bottleneck detected.",
            _ when line.DefectCount > 10 => "CRITICAL: Quality issue! Stop line.",
            _ => "Urgent: Increase manpower or check machine health."
        };
    }
}