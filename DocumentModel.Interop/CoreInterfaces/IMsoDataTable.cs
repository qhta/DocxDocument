
namespace DocumentModel.Interop.Core;

public interface IMsoDataTable
{
  bool ShowLegendKey { get; set; }
  bool HasBorderHorizontal { get; set; }
  bool HasBorderVertical { get; set; }
  bool HasBorderOutline { get; set; }
  IMsoBorder Border { get; }
  ChartFont Font { get; }
  void Select();
  void Delete();
  object Parent { get; }
  object AutoScaleFont { get; set; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}