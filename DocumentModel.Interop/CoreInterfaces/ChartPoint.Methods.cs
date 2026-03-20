
namespace DocumentModel.Interop.Core;

public partial interface ChartPoint
{
  public object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);
  public object ClearFormats();
  public object Copy();
  public object Delete();
  public object Paste();
  public object Select();
  public object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);
  public double PieSliceLocation(XlPieSliceLocation loc, XlPieSliceIndex Index);
}
