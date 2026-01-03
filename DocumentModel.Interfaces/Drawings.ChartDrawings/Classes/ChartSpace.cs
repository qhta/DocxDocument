namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the complete chart space container that encapsulates all chart elements and their configurations.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the root container for a chart drawing
///   that encompasses the entire chart structure including data sources, visual representation, styling, and
///   output settings. The chart space serves as the top-level wrapper that combines the chart data configuration,
///   the chart visualization itself, global styling properties, text formatting, color mappings, format overrides,
///   print settings, and extensibility support. This provides a complete and self-contained chart package that
///   can be embedded in Office documents, presentations, and spreadsheets. The chart space coordinates all aspects
///   of chart creation, rendering, and output, ensuring consistent behavior across different contexts and output
///   formats. It represents the entire chart object as stored in Office documents, maintaining all information
///   needed to render, edit, and reproduce the chart accurately.
/// </remarks>
public interface ChartSpace : IModelElement
{
  /// <summary>
  ///   Gets or sets the data source configuration for the chart.
  /// </summary>
  /// <value>
  ///   A <see cref="ChartData"/> object defining where the chart retrieves its data,
  ///   or <c>null</c> if no data source is configured.
  /// </value>
  /// <remarks>
  ///   The chart data specifies whether the chart uses external data sources (such as Excel ranges) or
  ///   embedded data stored within the chart structure. This determines how the chart accesses values,
  ///   categories, and series information for visualization.
  /// </remarks>
  public ChartData? ChartData { get; set; }

  /// <summary>
  ///   Gets or sets the chart visualization containing the plot area, title, and legend.
  /// </summary>
  /// <value>
  ///   A <see cref="Chart"/> object defining the complete chart visualization,
  ///   or <c>null</c> if no chart is defined.
  /// </value>
  /// <remarks>
  ///   The chart represents the visual components including the plot area with data series and axes,
  ///   the chart title, and the legend. This is the core visualization element that displays the data
  ///   in graphical form.
  /// </remarks>
  public Chart? Chart { get; set; }

  /// <summary>
  ///   Gets or sets the global shape properties applied to the entire chart space.
  /// </summary>
  /// <value>
  ///   A <see cref="ShapeProperties"/> object defining fill, line, and effect properties for the chart container,
  ///   or <c>null</c> if default styling is used.
  /// </value>
  /// <remarks>
  ///   Shape properties control the visual appearance of the chart space container, including background fill,
  ///   border styling, shadows, and other visual effects. These properties apply to the entire chart area
  ///   and provide the outermost visual styling layer.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the global text properties applied to text elements throughout the chart.
  /// </summary>
  /// <value>
  ///   A <see cref="TxPrTextBody"/> object defining default font, alignment, and paragraph properties,
  ///   or <c>null</c> if default text formatting is used.
  /// </value>
  /// <remarks>
  ///   Text properties provide default formatting for all text elements in the chart, including titles,
  ///   labels, and legends, unless overridden by specific element formatting. This ensures consistent
  ///   typography throughout the chart.
  /// </remarks>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   Gets or sets the color mapping configuration that defines how theme colors are applied to the chart.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorMappingType"/> object defining the mapping between theme colors and chart elements,
  ///   or <c>null</c> if default color mapping is used.
  /// </value>
  /// <remarks>
  ///   Color mapping connects the chart's color scheme to the document's theme colors, ensuring visual
  ///   consistency with the overall document design. This enables charts to automatically adapt their
  ///   colors when the document theme changes.
  /// </remarks>
  public ColorMappingType? ColorMappingType { get; set; }

  /// <summary>
  ///   Gets or sets the format overrides that customize specific formatting aspects of the chart.
  /// </summary>
  /// <value>
  ///   A <see cref="FormatOverrides"/> object defining custom formatting that supersedes default settings,
  ///   or <c>null</c> if no format overrides are applied.
  /// </value>
  /// <remarks>
  ///   Format overrides allow specific formatting rules to be applied that take precedence over default
  ///   or inherited formatting. This provides fine-grained control over chart appearance for specific
  ///   elements or scenarios.
  /// </remarks>
  public FormatOverrides? FormatOverrides { get; set; }

  /// <summary>
  ///   Gets or sets the print settings that control how the chart is rendered when printed.
  /// </summary>
  /// <value>
  ///   A <see cref="PrintSettings"/> object defining page setup, margins, and print-specific options,
  ///   or <c>null</c> if default print settings are used.
  /// </value>
  /// <remarks>
  ///   Print settings configure how the chart appears in printed output, including page orientation,
  ///   scaling, margins, headers, and footers. These settings ensure the chart prints correctly and
  ///   professionally regardless of the display settings.
  /// </remarks>
  public PrintSettings? PrintSettings { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Extension elements allow for future enhancements and custom properties without breaking
  ///   compatibility with existing implementations. This enables new chart features and capabilities
  ///   to be added while maintaining backward compatibility with earlier versions.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}