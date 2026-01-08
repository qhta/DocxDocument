namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a trendline definition for a chart series or data set.
///   A trendline is a graphical representation of trends in data, such as linear, polynomial, or moving average, and is used to analyze patterns or forecast future values.
///   This interface provides configuration for trendline type, order, period, display options, and visual properties.
/// </summary>
public interface Trendline: CollectionItem
{
  /// <summary>
  ///   Name of the trendline, used for identification or display in the chart legend.
  /// </summary>
  public string? TrendlineName { get; set; }

  /// <summary>
  ///   Visual and shape properties for the trendline.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Type of trendline, such as linear, exponential, or polynomial.
  /// </summary>
  public TrendlineKind? TrendlineType { get; set; }

  /// <summary>
  ///   Order of the polynomial trendline, if applicable.
  /// </summary>
  public Byte? PolynomialOrder { get; set; }

  /// <summary>
  ///   Period for moving average or similar trendline types.
  /// </summary>
  public UInt32? Period { get; set; }

  /// <summary>
  ///   Number of units the trendline is extended forward beyond the data.
  /// </summary>
  public Double? Forward { get; set; }

  /// <summary>
  ///   Number of units the trendline is extended backward before the data.
  /// </summary>
  public Double? Backward { get; set; }

  /// <summary>
  ///   Intercept value for the trendline, if specified.
  /// </summary>
  public Double? Intercept { get; set; }

  /// <summary>
  ///   Indicates whether the R-squared value is displayed on the chart.
  /// </summary>
  public bool? DisplayRSquaredValue { get; set; }

  /// <summary>
  ///   Indicates whether the trendline equation is displayed on the chart.
  /// </summary>
  public bool? DisplayEquation { get; set; }

  /// <summary>
  ///   Label for the trendline, providing additional information or customization.
  /// </summary>
  public TrendlineLabel? TrendlineLabel { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional trendline customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}