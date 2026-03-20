
namespace DocumentModel.Interop.Core;

public interface IMsoDataTable
{
  public bool ShowLegendKey { get; set; }
  public bool HasBorderHorizontal { get; set; }
  public bool HasBorderVertical { get; set; }
  public bool HasBorderOutline { get; set; }
  public IMsoBorder Border { get; }
  public ChartFont Font { get; }
  public void Select();
  public void Delete();
  public object AutoScaleFont { get; set; }
  public IMsoChartFormat Format { get; }
}
