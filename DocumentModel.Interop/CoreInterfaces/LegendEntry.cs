
namespace DocumentModel.Interop.Core;

public interface LegendEntry
{
  public object Delete();
  public ChartFont Font { get; }
  public int Index { get; }
  public IMsoLegendKey LegendKey { get; }
  public object Select();
  public object AutoScaleFont { get; set; }
  public double Left { get; }
  public double Top { get; }
  public double Width { get; }
  public double Height { get; }
  public IMsoChartFormat Format { get; }
}
