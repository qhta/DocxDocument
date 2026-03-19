
namespace DocumentModel.Interop.Core;

public interface LegendEntry
{
  object Parent { get; }
  object Delete();
  ChartFont Font { get; }
  int Index { get; }
  IMsoLegendKey LegendKey { get; }
  object Select();
  object AutoScaleFont { get; set; }
  double Left { get; }
  double Top { get; }
  double Width { get; }
  double Height { get; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}