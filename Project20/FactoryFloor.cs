using Project20;
using System.Linq;

public class FactoryFloor
{
    private readonly List<ProductionLine> _lines = new();

    public void AddLine(ProductionLine line) => _lines.Add(line);

    public void PrintShiftReport()
    {
        Console.WriteLine($"--- Shift Report: {DateTime.Now:dd-MMM-yyyy} ---");

        // Foreach for display
        foreach (var line in _lines)
        {
            Console.WriteLine(line.ToString());
        }

        // LINQ: Identify lines with high defect rates (> 5% of output)
        var problematicLines = _lines
            .Where(l => l.ActualOutput > 0 && (double)l.DefectCount / l.ActualOutput > 0.05)
            .Select(l => l.LineId);

        if (problematicLines.Any())
        {
            Console.WriteLine($"\nAttention Needed on Lines: {string.Join(", ", problematicLines)}");
        }
    }
}