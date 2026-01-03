namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a complete chart visualization with its associated components.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the top-level container for a chart
///   drawing that encompasses all the visual and structural elements of a chart. A chart combines a title,
///   a plot area containing the data visualization and axes, a legend for identifying data series, and
///   support for custom extensions. This interface represents the complete chart object as it appears in
///   Office documents, providing a unified structure for various chart types including bar charts, line charts,
///   pie charts, scatter plots, histograms, and more. The chart serves as the root element that coordinates
///   all chart components and defines their relationships, enabling complex data visualizations with
///   consistent formatting and layout. Charts can be embedded in documents, presentations, and spreadsheets,
///   providing powerful data visualization capabilities across the Office suite.
/// </remarks>
public interface Chart : IModelElement
{
  /// <summary>
  ///   Gets or sets the title displayed at the top of the chart.
  /// </summary>
  /// <value>
  ///   A <see cref="ChartTitle"/> object defining the chart's title and its formatting,
  ///   or <c>null</c> if no title is displayed.
  /// </value>
  /// <remarks>
  ///   The chart title provides a high-level description of what the chart represents, helping users
  ///   understand the purpose and context of the data visualization. It typically appears at the top
  ///   of the chart and can be customized with various text formatting and styling options.
  /// </remarks>
  public ChartTitle? ChartTitle { get; set; }

  /// <summary>
  ///   Gets or sets the plot area containing the data series, axes, and gridlines.
  /// </summary>
  /// <value>
  ///   A <see cref="PlotArea"/> object defining the chart's data visualization region,
  ///   or <c>null</c> if no plot area is defined.
  /// </value>
  /// <remarks>
  ///   The plot area is the core region of the chart where data is actually visualized. It contains
  ///   the data series (bars, lines, points, etc.), axes that provide scale and context, gridlines
  ///   for easier value reading, and other elements that directly represent or support the data display.
  ///   This is typically the largest and most important component of the chart.
  /// </remarks>
  public PlotArea? PlotArea { get; set; }

  /// <summary>
  ///   Gets or sets the legend that identifies the data series in the chart.
  /// </summary>
  /// <value>
  ///   A <see cref="Legend"/> object defining the chart's legend and its positioning,
  ///   or <c>null</c> if no legend is displayed.
  /// </value>
  /// <remarks>
  ///   The legend provides a key that maps visual elements (colors, markers, patterns) to their
  ///   corresponding data series names. It helps users identify what each visual element represents,
  ///   particularly in charts with multiple data series. The legend can be positioned in various
  ///   locations around the chart (top, bottom, left, right, or overlay) and customized for appearance.
  /// </remarks>
  public Legend? Legend { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Extension elements allow for future enhancements and custom properties without breaking
  ///   compatibility with existing implementations. This enables new chart features and customizations
  ///   to be added while maintaining backward compatibility.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}