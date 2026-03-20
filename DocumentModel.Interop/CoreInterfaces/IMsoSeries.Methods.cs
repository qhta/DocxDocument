
namespace DocumentModel.Interop.Core;

public partial interface IMsoSeries
{
  public object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);
  public object ClearFormats();
  public object Copy();
  public object DataLabels(object Index);
  public object Delete();
  public object ErrorBar
    (XlErrorBarDirection Direction, XlErrorBarInclude Include, XlErrorBarType Type, object Amount, object MinusValues);
  public object Paste();
  public object Points(object Index);
  public object Select();
  public object Trendlines(object Index);
  public void ApplyCustomType(XlChartType ChartType);
  public object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);
}
