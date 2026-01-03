namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the collection of data labels and their default settings for a chart series or chart.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the data labels configuration that applies
///   to a series or entire chart, providing both default formatting settings and individual label definitions.
///   The DataLabels interface serves as a container that establishes default properties (position, number formatting,
///   styling, text formatting, visibility, and separator) that apply to all labels in the series unless overridden
///   by individual <see cref="DataLabel"/> definitions. This hierarchical approach enables efficient label management
///   where common formatting is defined once at the series level, while specific data points can have customized
///   labels through the <see cref="Items"/> collection or suppressed labels through the <see cref="HiddenDataLabels"/>
///   collection. This structure supports various labeling strategies: showing labels for all data points with uniform
///   formatting, showing labels for select data points with custom formatting, or any combination thereof. The default
///   settings reduce redundancy and simplify label management for charts with many data points, while the individual
///   label collections provide flexibility for emphasizing or suppressing specific values.
/// </remarks>
public interface DataLabels : IModelElement
{
  /// <summary>
  ///   Gets or sets the default position for data labels relative to their data points.
  /// </summary>
  /// <value>
  ///   A <see cref="DataLabelPos"/> value specifying the default label position (e.g., above, below, center, left, right),
  ///   or <c>null</c> to use the chart type's default position.
  /// </value>
  /// <remarks>
   ///   The position setting establishes the default placement for all data labels in the series. Individual labels
  ///   defined in the <see cref="Items"/> collection can override this default with their own position settings.
  ///   The appropriate position varies by chart type: column charts typically use above or inside positions,
  ///   bar charts use right or inside, pie charts use outside with leader lines, and line charts use above or right.
  /// </remarks>
  public DataLabelPos? Pos { get; set; }

  /// <summary>
  ///   Gets or sets the default number formatting applied to numeric values in data labels.
  /// </summary>
  /// <value>
  ///   A <see cref="NumberFormat"/> object defining the format code for numeric display,
  ///   or <c>null</c> if default number formatting is used.
  /// </value>
  /// <remarks>
  ///   Number formatting controls how numeric values are displayed across all labels, including decimal places,
  ///   currency symbols, percentage formatting, thousand separators, and scientific notation. This default can
  ///   be overridden by individual labels in the <see cref="Items"/> collection. Consistent number formatting
  ///   across labels ensures professional appearance and aids in value comparison.
  /// </remarks>
  public NumberFormat? NumberFormat { get; set; }

  /// <summary>
  ///   Gets or sets the default visual styling properties for data labels.
  /// </summary>
  /// <value>
  ///   A <see cref="ShapeProperties"/> object defining fill, line, and effect properties,
  ///   or <c>null</c> if default styling is used.
  /// </value>
  /// <remarks>
  ///   Shape properties control the default visual appearance of label containers, including background fill,
  ///   border styling, shadows, and other visual effects. These properties apply to all labels unless overridden
  ///   by individual label definitions. Consistent styling helps labels integrate visually with the chart design.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the default text formatting properties for data label text.
  /// </summary>
  /// <value>
  ///   A <see cref="TxPrTextBody"/> object defining font, alignment, and paragraph properties,
  ///   or <c>null</c> if default text formatting is used.
  /// </value>
  /// <remarks>
  ///   Text properties control the default formatting of label text, including font family, size, color,
  ///   style (bold, italic), alignment, rotation, and spacing. These defaults ensure consistent typography
  ///   across all labels in the series, though individual labels can override these settings.
  /// </remarks>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   Gets or sets the default visibility settings controlling which components are displayed in data labels.
  /// </summary>
  /// <value>
  ///   A <see cref="DataLabelVisibilities"/> object specifying which label components to show or hide by default,
  ///   or <c>null</c> if default visibility settings are used.
  /// </value>
  /// <remarks>
  ///   Data label visibility settings determine which information types (value, category name, series name,
  ///   percentage, legend key, bubble size) appear in labels by default. This establishes what information
  ///   is shown across all labels, though individual labels in the <see cref="Items"/> collection can
  ///   customize their visibility settings independently.
  /// </remarks>
  public DataLabelVisibilities? DataLabelVisibilities { get; set; }

  /// <summary>
  ///   Gets or sets the default separator string used between multiple label components.
  /// </summary>
  /// <value>
  ///   A string containing the separator text (e.g., ", ", " - ", newline character),
  ///   or <c>null</c> to use the default separator.
  /// </value>
  /// <remarks>
  ///   The separator determines how multiple pieces of information are delimited when labels display more than
  ///   one component. Common separators include commas, hyphens, spaces, or newline characters. This default
  ///   separator applies to all labels unless overridden by individual label definitions.
  /// </remarks>
  public string? SeparatorXsdString { get; set; }

  /// <summary>
  ///   Gets or sets the collection of individual data label definitions with custom formatting.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="DataLabel"/> objects defining customized labels for specific data points,
  ///   or <c>null</c> if no custom labels are defined.
  /// </value>
  /// <remarks>
  ///   This collection contains explicit label definitions for data points that require formatting different
  ///   from the default settings. Each <see cref="DataLabel"/> in the collection is associated with a specific
  ///   data point through its index and can override any of the default properties (position, number format,
  ///   styling, text formatting, visibility, or separator). This enables selective emphasis or customization
  ///   of important data points while maintaining consistent formatting for the majority of labels.
  /// </remarks>
  public Collection<DataLabel>? Items { get; set; }

  /// <summary>
  ///   Gets or sets the collection of hidden label indicators for data points that should not display labels.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="DataLabelHidden"/> objects identifying data points with suppressed labels,
  ///   or <c>null</c> if no labels are explicitly hidden.
  /// </value>
  /// <remarks>
  ///   This collection contains lightweight markers that identify data points whose labels should be hidden,
  ///   even when the series has labels enabled. Each <see cref="DataLabelHidden"/> identifies a data point
  ///   by index, allowing selective suppression of labels for outliers, zero values, or intermediate points
  ///   to reduce clutter. This provides fine-grained control over label visibility without requiring full
  ///   <see cref="DataLabel"/> definitions for every data point.
  /// </remarks>
  public Collection<DataLabelHidden>? HiddenDataLabels { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Extension elements allow for future enhancements to data labels functionality without breaking
  ///   compatibility with existing implementations. This could include additional positioning algorithms,
  ///   formatting options, or interactive features introduced in future versions.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}