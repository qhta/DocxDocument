
namespace DocumentModel.Interop.Core;

public partial interface LegendEntry
{
  public ChartFont Font { get; }
  public int Index { get; }
  public IMsoLegendKey LegendKey { get; }
  public object AutoScaleFont { get; set; }
  public double Left { get; }
  public double Top { get; }
  public double Width { get; }
  public double Height { get; }
  public IMsoChartFormat Format { get; }
}
