
namespace DocumentModel.Interop.Core;

public interface IMsoTickLabels
{
  object Delete();
  ChartFont Font { get; }
  string Name { get; }
  string NumberFormat { get; set; }
  bool NumberFormatLinked { get; set; }
  object NumberFormatLocal { get; set; }
  XlTickLabelOrientation Orientation { get; set; }
  object Select();
  int ReadingOrder { get; set; }
  object AutoScaleFont { get; set; }
  int Depth { get; }
  int Offset { get; set; }
  int Alignment { get; set; }
  bool MultiLevel { get; set; }
  IMsoChartFormat Format { get; }
}