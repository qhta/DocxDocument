
namespace DocumentModel.Interop.Core;

public interface IMsoSeries
{
  object Parent { get; }

  object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);

  XlAxisGroup AxisGroup { get; set; }
  IMsoBorder Border { get; }
  object ClearFormats();
  object Copy();
  object DataLabels(object Index);
  object Delete();

  object ErrorBar
    (XlErrorBarDirection Direction, XlErrorBarInclude Include, XlErrorBarType Type, object Amount, object MinusValues);

  IMsoErrorBars ErrorBars { get; }
  int Explosion { get; set; }
  string Formula { get; set; }
  string FormulaLocal { get; set; }
  string FormulaR1C1 { get; set; }
  string FormulaR1C1Local { get; set; }
  bool HasDataLabels { get; set; }
  bool HasErrorBars { get; set; }
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  bool InvertIfNegative { get; set; }
  int MarkerBackgroundColor { get; set; }
  XlColorIndex MarkerBackgroundColorIndex { get; set; }
  int MarkerForegroundColor { get; set; }
  XlColorIndex MarkerForegroundColorIndex { get; set; }
  int MarkerSize { get; set; }
  XlMarkerStyle MarkerStyle { get; set; }
  string Name { get; set; }
  object Paste();
  XlChartPictureType PictureType { get; set; }
  double PictureUnit { get; set; }
  int PlotOrder { get; set; }
  object Points(object Index);
  object Select();
  bool Smooth { get; set; }
  object Trendlines(object Index);
  int Type { get; set; }
  XlChartType ChartType { get; set; }
  void ApplyCustomType(XlChartType ChartType);
  object Values { get; set; }
  object XValues { get; set; }
  object BubbleSizes { get; set; }
  XlBarShape BarShape { get; set; }
  bool ApplyPictToSides { get; set; }
  bool ApplyPictToFront { get; set; }
  bool ApplyPictToEnd { get; set; }
  bool Has3DEffect { get; set; }
  bool Shadow { get; set; }
  bool HasLeaderLines { get; set; }
  IMsoLeaderLines LeaderLines { get; }

  object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);

  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
  double PictureUnit2 { get; set; }
  int PlotColorIndex { get; }
  int InvertColor { get; set; }
  XlColorIndex InvertColorIndex { get; set; }
  bool IsFiltered { get; set; }
}