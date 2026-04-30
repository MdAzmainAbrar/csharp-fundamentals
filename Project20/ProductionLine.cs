namespace Project20;

public class ProductionLine(string lineId, string styleName, int target)
{
    public string LineId { get; } = lineId;
    public string StyleName { get; } = styleName;
    public int Target { get; } = target;
    public int ActualOutput { get; set; } = 0;
    public int DefectCount { get; set; } = 0;

    // ToString Override: Formats a progress bar for the supervisor
    public override string ToString()
    {
        double efficiency = Target > 0 ? (double)ActualOutput / Target * 100 : 0;
        return $"Line: {LineId} | Style: {StyleName} | Output: {ActualOutput}/{Target} ({efficiency:F1}% Eff.) | Defects: {DefectCount}";
    }
}