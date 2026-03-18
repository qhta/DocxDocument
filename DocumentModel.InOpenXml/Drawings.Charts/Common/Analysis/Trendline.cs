namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a trendline definition for a chart series or data set.
///   A trendline is a graphical representation of trends in data, such as linear, polynomial, or moving average, and is used to analyze patterns or forecast future values.
///   This class provides configuration for trendline type, order, period, display options, and visual properties.
/// </summary>
[OpenXmlType(typeof(DXDC.Trendline))]
public partial class Trendline: ModelElement<DXDC.Trendline>
{
  /// <summary>
  ///   Name of the trendline, used for identification or display in the chart legend.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.TrendlineName))]
  public string? TrendlineName
  {
    get => _TrendlineName;
    set => UpdateField(ref _TrendlineName, value, nameof(TrendlineName));
  }

  private string? _TrendlineName;

  /// <summary>
  ///   Visual and shape properties for the trendline.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   Type of trendline, such as linear, exponential, or polynomial.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.TrendlineType))]
  public TrendlineType? TrendlineType
  {
    get => _TrendlineType;
    set => UpdateField(ref _TrendlineType, value, nameof(TrendlineType));
  }

  private TrendlineType? _TrendlineType;

  /// <summary>
  ///   Order of the polynomial trendline, if applicable.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.PolynomialOrder))]
  public Byte? PolynomialOrder
  {
    get => _PolynomialOrder;
    set => UpdateField(ref _PolynomialOrder, value, nameof(PolynomialOrder));
  }

  private Byte? _PolynomialOrder;

  /// <summary>
  ///   Period for moving average or similar trendline types.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Period))]
  public UInt32? Period { get => _Period; set => UpdateField(ref _Period, value, nameof(Period)); }

  private UInt32? _Period;

  /// <summary>
  ///   Number of units the trendline is extended forward beyond the data.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Forward))]
  public Double? Forward { get => _Forward; set => UpdateField(ref _Forward, value, nameof(Forward)); }

  private Double? _Forward;

  /// <summary>
  ///   Number of units the trendline is extended backward before the data.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Backward))]
  public Double? Backward { get => _Backward; set => UpdateField(ref _Backward, value, nameof(Backward)); }

  private Double? _Backward;

  /// <summary>
  ///   Intercept value for the trendline, if specified.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Intercept))]
  public Double? Intercept { get => _Intercept; set => UpdateField(ref _Intercept, value, nameof(Intercept)); }

  private Double? _Intercept;

  /// <summary>
  ///   Indicates whether the R-squared value is displayed on the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DisplayRSquaredValue))]
  public bool? DisplayRSquaredValue
  {
    get => _DisplayRSquaredValue;
    set => UpdateField(ref _DisplayRSquaredValue, value, nameof(DisplayRSquaredValue));
  }

  private bool? _DisplayRSquaredValue;

  /// <summary>
  ///   Indicates whether the trendline equation is displayed on the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DisplayEquation))]
  public bool? DisplayEquation
  {
    get => _DisplayEquation;
    set => UpdateField(ref _DisplayEquation, value, nameof(DisplayEquation));
  }

  private bool? _DisplayEquation;

  /// <summary>
  ///   Label for the trendline, providing additional information or customization.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.TrendlineLabel))]
  public TrendlineLabel? TrendlineLabel
  {
    get => _TrendlineLabel;
    set => UpdateField(ref _TrendlineLabel, value, nameof(TrendlineLabel));
  }

  private TrendlineLabel? _TrendlineLabel;

  /// <summary>
  ///   Collection of extension elements for additional trendline customization.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}