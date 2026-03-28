namespace DocumentModel.Interop;

/// <summary>
/// Represents a legend key in a chart legend.
/// </summary>
public partial interface LegendKey : InteropObject
{
  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

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
  public int PictureType { get; set; }

  /// <summary>
  /// The picture unit.
  /// </summary>
  public double PictureUnit { get; set; }

  /// <summary>
  /// The smooth.
  /// </summary>
  public bool Smooth { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  public double Left { get; }

  /// <summary>
  /// The top.
  /// </summary>
  public double Top { get; }

  /// <summary>
  /// The width.
  /// </summary>
  public double Width { get; }

  /// <summary>
  /// The height.
  /// </summary>
  public double Height { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  public bool Shadow { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }

  /// <summary>
  /// The picture unit2.
  /// </summary>
  public double PictureUnit2 { get; set; }
}
