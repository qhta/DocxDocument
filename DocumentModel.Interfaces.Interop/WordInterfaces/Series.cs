namespace DocumentModel.Interop;

/// <summary>
/// Represents a series in a chart.
/// </summary>
public partial interface Series : InteropObject
{
  /// <summary>
  /// The axis group.
  /// </summary>
  public XlAxisGroup AxisGroup { get; set; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The error bars.
  /// </summary>
  public ErrorBars ErrorBars { get; }

  /// <summary>
  /// The explosion.
  /// </summary>
  public int Explosion { get; set; }

  /// <summary>
  /// The formula.
  /// </summary>
  public string Formula { get; set; }

  /// <summary>
  /// The formula local.
  /// </summary>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// The formula r1 c1.
  /// </summary>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// The formula r1 c1 local.
  /// </summary>
  public string FormulaR1C1Local { get; set; }

  /// <summary>
  /// The has data labels.
  /// </summary>
  public bool HasDataLabels { get; set; }

  /// <summary>
  /// The has error bars.
  /// </summary>
  public bool HasErrorBars { get; set; }

  /// <summary>
  /// The interior.
  /// </summary>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The invert if negative.
  /// </summary>
  public bool InvertIfNegative { get; set; }

  /// <summary>
  /// The marker background color.
  /// </summary>
  public int MarkerBackgroundColor { get; set; }

  /// <summary>
  /// The marker background color index.
  /// </summary>
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// The marker foreground color.
  /// </summary>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// The marker foreground color index.
  /// </summary>
  public XlColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// The marker size.
  /// </summary>
  public int MarkerSize { get; set; }

  /// <summary>
  /// The marker style.
  /// </summary>
  public XlMarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The picture type.
  /// </summary>
  public XlChartPictureType PictureType { get; set; }

  /// <summary>
  /// The picture unit.
  /// </summary>
  public double PictureUnit { get; set; }

  /// <summary>
  /// The plot order.
  /// </summary>
  public int PlotOrder { get; set; }

  /// <summary>
  /// The smooth.
  /// </summary>
  public bool Smooth { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public int Type { get; set; }

  /// <summary>
  /// The chart type.
  /// </summary>
  //public Core.XlChartType ChartType { get; set; }

  /// <summary>
  /// The values.
  /// </summary>
  public object Values { get; set; }

  /// <summary>
  /// The xvalues.
  /// </summary>
  public object XValues { get; set; }

  /// <summary>
  /// The bubble sizes.
  /// </summary>
  public object BubbleSizes { get; set; }

  /// <summary>
  /// The bar shape.
  /// </summary>
  public XlBarShape BarShape { get; set; }

  /// <summary>
  /// The apply pict to sides.
  /// </summary>
  public bool ApplyPictToSides { get; set; }

  /// <summary>
  /// The apply pict to front.
  /// </summary>
  public bool ApplyPictToFront { get; set; }

  /// <summary>
  /// The apply pict to end.
  /// </summary>
  public bool ApplyPictToEnd { get; set; }

  /// <summary>
  /// The has3 deffect.
  /// </summary>
  public bool Has3DEffect { get; set; }

  /// <summary>
  /// The shadow.
  /// </summary>
  public bool Shadow { get; set; }

  /// <summary>
  /// The has leader lines.
  /// </summary>
  public bool HasLeaderLines { get; set; }

  /// <summary>
  /// The leader lines.
  /// </summary>
  public LeaderLines LeaderLines { get; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }

  /// <summary>
  /// The picture unit2.
  /// </summary>
  public double PictureUnit2 { get; set; }

  /// <summary>
  /// The plot color index.
  /// </summary>
  public int PlotColorIndex { get; }

  /// <summary>
  /// The invert color.
  /// </summary>
  public int InvertColor { get; set; }

  /// <summary>
  /// The invert color index.
  /// </summary>
  public XlColorIndex InvertColorIndex { get; set; }

  /// <summary>
  /// The is filtered.
  /// </summary>
  public bool IsFiltered { get; set; }
}
