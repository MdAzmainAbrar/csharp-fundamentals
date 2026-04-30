using Project20;
//Project: KnitTrack — A Production Line Efficiency Monitor
//This project focuses on a Line-Wise Production Tracker.

// 1. Initialize the Factory Floor
var fakirFloor = new FactoryFloor();

// 2. Add real-world lines (Example: Sewing Lines for T-Shirts/Polo)
// Syntax: (LineID, Style, Target)
var line1 = new ProductionLine("LINE-01", "Basic-Tee-A1", 450);
var line2 = new ProductionLine("LINE-02", "Polo-Shirt-Blue", 300);
var line3 = new ProductionLine("LINE-03", "Tank-Top-X", 500);

fakirFloor.AddLine(line1);
fakirFloor.AddLine(line2);
fakirFloor.AddLine(line3);

// 3. Simulate Production Progress
// (In a real factory, this data would come from a scanner or a tablet)
line1.ActualOutput = 440; // Good efficiency
line1.DefectCount = 5;

line2.ActualOutput = 150; // Underperforming
line2.DefectCount = 2;

line3.ActualOutput = 480; // High output but high defects
line3.DefectCount = 35;

// 4. Generate the Shift Report
Console.WriteLine("====================================================");
Console.WriteLine("    FAKIR KNITWEARS LTD - PRODUCTION MONITOR");
Console.WriteLine("====================================================");

fakirFloor.PrintShiftReport();

// 5. Use the Switch Logic to get AI-driven advice for specific lines
Console.WriteLine("\n--- Supervisor Insights ---");
Console.WriteLine($"Line 02 Status: {SupervisorAI.GetLineStatus(line2)}");
Console.WriteLine($"Line 03 Status: {SupervisorAI.GetLineStatus(line3)}");
Console.WriteLine("====================================================");