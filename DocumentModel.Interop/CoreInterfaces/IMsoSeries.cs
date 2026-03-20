
namespace DocumentModel.Interop.Core;

public interface IMsoSeries
{
  public object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);

  public XlAxisGroup AxisGroup { get; set; }
  public IMsoBorder Border { get; }
  public object ClearFormats();
  public object Copy();
  public object DataLabels(object Index);
  public object Delete();

  public object ErrorBar
    (XlErrorBarDirection Direction, XlErrorBarInclude Include, XlErrorBarType Type, object Amount, object MinusValues);

  public IMsoErrorBars ErrorBars { get; }
  public int Explosion { get; set; }
  public string Formula { get; set; }
  public string FormulaLocal { get; set; }
  public string FormulaR1C1 { get; set; }
  public string FormulaR1C1Local { get; set; }
  public bool HasDataLabels { get; set; }
  public bool HasErrorBars { get; set; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public bool InvertIfNegative { get; set; }
  public int MarkerBackgroundColor { get; set; }
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }
  public int MarkerForegroundColor { get; set; }
  public XlColorIndex MarkerForegroundColorIndex { get; set; }
  public int MarkerSize { get; set; }
  public XlMarkerStyle MarkerStyle { get; set; }
  public string Name { get; set; }
  public object Paste();
  public XlChartPictureType PictureType { get; set; }
  public double PictureUnit { get; set; }
  public int PlotOrder { get; set; }
  public object Points(object Index);
  public object Select();
  public bool Smooth { get; set; }
  public object Trendlines(object Index);
  public int Type { get; set; }
  public XlChartType ChartType { get; set; }
  public void ApplyCustomType(XlChartType ChartType);
  public object Values { get; set; }
  public object XValues { get; set; }
  public object BubbleSizes { get; set; }
  public XlBarShape BarShape { get; set; }
  public bool ApplyPictToSides { get; set; }
  public bool ApplyPictToFront { get; set; }
  public bool ApplyPictToEnd { get; set; }
  public bool Has3DEffect { get; set; }
  public bool Shadow { get; set; }
  public bool HasLeaderLines { get; set; }
  public IMsoLeaderLines LeaderLines { get; }

  public object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);

  public IMsoChartFormat Format { get; }
  public double PictureUnit2 { get; set; }
  public int PlotColorIndex { get; }
  public int InvertColor { get; set; }
  public XlColorIndex InvertColorIndex { get; set; }
  public bool IsFiltered { get; set; }
}
