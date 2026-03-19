namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a trendline in a chart.
/// </summary>
public partial interface Trendline : InteropObject
{
  /// <summary>
  /// The backward.
  /// </summary>
  public double Backward { get; set; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The data label.
  /// </summary>
  public DataLabel DataLabel { get; }

  /// <summary>
  /// The display equation.
  /// </summary>
  public bool DisplayEquation { get; set; }

  /// <summary>
  /// The display rsquared.
  /// </summary>
  public bool DisplayRSquared { get; set; }

  /// <summary>
  /// The forward.
  /// </summary>
  public double Forward { get; set; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The intercept.
  /// </summary>
  public double Intercept { get; set; }

  /// <summary>
  /// The intercept is auto.
  /// </summary>
  public bool InterceptIsAuto { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The name is auto.
  /// </summary>
  public bool NameIsAuto { get; set; }

  /// <summary>
  /// The order.
  /// </summary>
  public int Order { get; set; }

  /// <summary>
  /// The period.
  /// </summary>
  public int Period { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public XlTrendlineType Type { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }

  /// <summary>
  /// The backward2.
  /// </summary>
  public double Backward2 { get; set; }

  /// <summary>
  /// The forward2.
  /// </summary>
  public double Forward2 { get; set; }
}
