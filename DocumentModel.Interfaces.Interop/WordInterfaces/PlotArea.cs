namespace DocumentModel.Interop;

/// <summary>
/// Represents the plot area of a chart.
/// </summary>
public partial interface PlotArea : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The height.
  /// </summary>
  public double Height { get; set; }

  /// <summary>
  /// The interior.
  /// </summary>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The left.
  /// </summary>
  public double Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  public double Top { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public double Width { get; set; }

  /// <summary>
  /// The inside left.
  /// </summary>
  public double InsideLeft { get; set; }

  /// <summary>
  /// The inside top.
  /// </summary>
  public double InsideTop { get; set; }

  /// <summary>
  /// The inside width.
  /// </summary>
  public double InsideWidth { get; set; }

  /// <summary>
  /// The inside height.
  /// </summary>
  public double InsideHeight { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  public XlChartElementPosition Position { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
