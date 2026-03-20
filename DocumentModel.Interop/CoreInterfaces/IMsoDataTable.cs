
namespace DocumentModel.Interop.Core;

public partial interface IMsoDataTable
{
  public bool ShowLegendKey { get; set; }
  public bool HasBorderHorizontal { get; set; }
  public bool HasBorderVertical { get; set; }
  public bool HasBorderOutline { get; set; }
  public IMsoBorder Border { get; }
  public ChartFont Font { get; }
  public object AutoScaleFont { get; set; }
  public IMsoChartFormat Format { get; }
}
