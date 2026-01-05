namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents an axis in a chart drawing that defines the scale and appearance of data dimensions.
/// </summary>
/// <remarks>
///   This interface defines a chart axis that provides the framework
///   for displaying and measuring data values in chart visualizations. Axes can be category axes (for discrete
///   data like labels or dates) or value axes (for continuous numeric data), each with their own scaling properties.
///   The axis includes comprehensive formatting options including title, units, gridlines (major and minor),
///   tick marks, tick labels, number formatting, visual styling, and text properties. Axes can be hidden while
///   still providing the underlying data structure, and support extensibility through custom extensions.
/// </remarks>
public interface Axis :
{
  /// <summary>
  ///   Gets or sets the unique identifier for this axis.
  /// </summary>
  /// <remarks>
   ///   The identifier uniquely distinguishes this axis from other axes in the chart, enabling
  ///   references from data series and other chart elements.
  /// </remarks>
  public UInt32? Id { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the axis is hidden from view.
  /// </summary>
  /// <remarks>
   ///   When hidden, the axis still provides the underlying data structure and scaling for the chart,
  ///   but its visual elements (labels, gridlines, tick marks) are not displayed.
  /// </remarks>
  public bool? Hidden { get; set; }

  /// <summary>
  ///   Gets or sets the scaling properties for a category axis.
  /// </summary>
  /// <remarks>
  ///   Category axes are used for discrete data such as text labels, dates, or categories.
  ///   Only one of <see cref="CategoryAxisScaling"/> or <see cref="ValueAxisScaling"/> should be set
  ///   for a given axis, depending on the axis type.
  /// </remarks>
  public CategoryAxisScaling? CategoryAxisScaling { get; set; }

  /// <summary>
  ///   Gets or sets the scaling properties for a value axis.
  /// </summary>
  /// <remarks>
  ///   Value axes are used for continuous numeric data and support minimum, maximum, and interval settings.
  ///   Only one of <see cref="CategoryAxisScaling"/> or <see cref="ValueAxisScaling"/> should be set
  ///   for a given axis, depending on the axis type.
  /// </remarks>
  public ValueAxisScaling? ValueAxisScaling { get; set; }

  /// <summary>
  ///   Gets or sets the title displayed for this axis.
  /// </summary>
  public AxisTitle? AxisTitle { get; set; }

  /// <summary>
  ///   Gets or sets the units displayed on this axis.
  /// </summary>
  /// <remarks>
  ///   Axis units provide context for the values (e.g., "Millions", "Thousands", "°C", "%").
  /// </remarks>
  public AxisUnits? AxisUnits { get; set; }

  /// <summary>
  ///   Gets or sets the major gridlines displayed perpendicular to this axis.
  /// </summary>
  /// <remarks>
  ///   Major gridlines correspond to the major tick marks and help users visually align data points
  ///   with axis values.
  /// </remarks>
  public MajorGridlinesGridlines? MajorGridlinesGridlines { get; set; }

  /// <summary>
  ///   Gets or sets the minor gridlines displayed perpendicular to this axis.
  /// </summary>
  /// <remarks>
  ///   Minor gridlines provide finer granularity between major gridlines, aiding in precise value reading.
  /// </remarks>
  public MinorGridlinesGridlines? MinorGridlinesGridlines { get; set; }

  /// <summary>
  ///   Gets or sets the major tick marks displayed along this axis.
  /// </summary>
  /// <remarks>
  ///   Major tick marks indicate primary intervals along the axis and typically align with axis labels.
  /// </remarks>
  public MajorTickMarksTickMarks? MajorTickMarksTickMarks { get; set; }

  /// <summary>
  ///   Gets or sets the minor tick marks displayed along this axis.
  /// </summary>
  /// <remarks>
  ///   Minor tick marks provide subdivisions between major tick marks for more precise value indication.
  /// </remarks>
  public MinorTickMarksTickMarks? MinorTickMarksTickMarks { get; set; }

  /// <summary>
  ///   Gets or sets the labels displayed at tick mark positions along this axis.
  /// </summary>
  /// <remarks>
  ///   Tick labels display the actual values or categories at each major tick mark position.
  /// </remarks>
  public TickLabels? TickLabels { get; set; }

  /// <summary>
  ///   Gets or sets the number formatting applied to numeric values on this axis.
  /// </summary>
  /// <remarks>
  ///   Number formatting controls how numeric values are displayed (e.g., decimal places, currency symbols,
  ///   percentage formatting, scientific notation).
  /// </remarks>
  public NumberFormat? NumberFormat { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for the axis line and related elements.
  /// </summary>
  /// <remarks>
  ///   Shape properties control the visual appearance of the axis line, including color, width, style,
  ///   and effects.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the text properties for text elements on this axis.
  /// </summary>
  /// <remarks>
  ///   Text properties control the formatting of axis title, labels, and other text elements,
  ///   including font family, size, color, and alignment.
  /// </remarks>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}