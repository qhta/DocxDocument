namespace DocumentModel.Interop;

/// <summary>
/// Represents a single point in a series in a chart.
/// </summary>
public partial interface Point : InteropObject
{
  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The data label.
  /// </summary>
  public DataLabel DataLabel { get; }

  /// <summary>
  /// The explosion.
  /// </summary>
  public int Explosion { get; set; }

  /// <summary>
  /// The has data label.
  /// </summary>
  public bool HasDataLabel { get; set; }

  /// <summary>
  /// The interior.
  /// </summary>
  public Interior Interior { get; }

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
  public Core.XlColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// The marker foreground color.
  /// </summary>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// The marker foreground color index.
  /// </summary>
  public Core.XlColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// The marker size.
  /// </summary>
  public int MarkerSize { get; set; }

  /// <summary>
  /// The marker style.
  /// </summary>
  public Core.XlMarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// The picture type.
  /// </summary>
  public Core.XlChartPictureType PictureType { get; set; }

  /// <summary>
  /// The picture unit.
  /// </summary>
  public double PictureUnit { get; set; }

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
  /// The shadow.
  /// </summary>
  public bool Shadow { get; set; }

  /// <summary>
  /// The secondary plot.
  /// </summary>
  public bool SecondaryPlot { get; set; }

  /// <summary>
  /// The fill.
  /// </summary>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The has3 deffect.
  /// </summary>
  public bool Has3DEffect { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }

  /// <summary>
  /// The picture unit2.
  /// </summary>
  public double PictureUnit2 { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public double Height { get; }

  /// <summary>
  /// The width.
  /// </summary>
  public double Width { get; }

  /// <summary>
  /// The top.
  /// </summary>
  public double Top { get; }

  /// <summary>
  /// The left.
  /// </summary>
  public double Left { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
}
