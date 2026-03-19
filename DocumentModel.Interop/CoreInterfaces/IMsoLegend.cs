
namespace DocumentModel.Interop.Core;

public interface IMsoLegend
{
  object Parent { get; }
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object Delete();
  ChartFont Font { get; }
  object LegendEntries(object Index);
  XlLegendPosition Position { get; set; }
  bool Shadow { get; set; }
  object Clear();
  double Height { get; set; }
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  double Left { get; set; }
  double Top { get; set; }
  double Width { get; set; }
  object AutoScaleFont { get; set; }
  bool IncludeInLayout { get; set; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}