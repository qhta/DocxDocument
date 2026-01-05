namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a label that displays information for a specific data point in a chart.
/// </summary>
/// <remarks>
///   This interface defines a data label element that provides textual
///   or visual information about individual data points in a chart. Data labels help users understand specific
///   values, categories, series names, or other contextual information directly on the chart without requiring
///   reference to axes or legends. Each data label is associated with a specific data point through an index,
///   and can be positioned relative to its data point (above, below, left, right, center, etc.). The label
///   supports comprehensive formatting including number formatting for numeric values, visual styling through
///   shape properties, text formatting, visibility controls for different label components (value, category name,
///   series name, etc.), and custom separators when multiple information types are displayed. Data labels can
///   significantly enhance chart readability by making key values immediately visible, though excessive use
///   may clutter the visualization. They are particularly valuable in charts with few data points or when
///   precise values need to be emphasized.
/// </remarks>
public interface DataLabel :
{
  /// <summary>
  ///   Gets or sets the zero-based index identifying which data point this label belongs to.
  /// </summary>
  /// <remarks>
   ///   The index associates this label with a specific data point in the series. The index is zero-based,
  ///   meaning the first data point has index 0, the second has index 1, and so on. This enables precise
  ///   control over which data points display labels, allowing selective labeling of important or outlier
  ///   values rather than labeling all points in a series.
  /// </remarks>
  public UInt32? Idx { get; set; }

  /// <summary>
  ///   Gets or sets the position of the data label relative to its data point.
  /// </summary>
  /// <remarks>
   ///   The position determines where the label appears relative to its associated data point. Different chart
  ///   types have different default and recommended positions. For example, column charts typically position
  ///   labels above or inside the columns, while pie charts often position labels outside the slices with
  ///   leader lines. The position can be adjusted to avoid overlapping with other chart elements or to
  ///   emphasize specific data points.
  /// </remarks>
  public DataLabelPos? Pos { get; set; }

  /// <summary>
  ///   Gets or sets the number formatting applied to numeric values in the data label.
  /// </summary>
  /// <remarks>
  ///   Number formatting controls how numeric values are displayed in the label, including decimal places,
  ///   currency symbols, percentage formatting, thousand separators, and scientific notation. Proper number
  ///   formatting ensures values are presented clearly and consistently with the chart's data and audience
  ///   expectations (e.g., "$1,234.56" for currency, "45.2%" for percentages, "1.23E+6" for scientific notation).
  /// </remarks>
  public NumberFormat? NumberFormat { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for the data label.
  /// </summary>
  /// <remarks>
  ///   Shape properties control the visual appearance of the label container, including background fill,
  ///   border styling, shadows, and other visual effects. These properties can make labels more prominent
  ///   or help them stand out against complex chart backgrounds. Common styling includes adding a subtle
  ///   background fill or border to improve label readability.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the text formatting properties for the data label text.
  /// </summary>
  /// <remarks>
  ///   Text properties control the formatting of the label text, including font family, size, color,
  ///   style (bold, italic), alignment, rotation, and spacing. This enables labels to be styled
  ///   consistently with the chart's overall design or to emphasize specific data points through
  ///   distinctive text formatting.
  /// </remarks>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   Gets or sets the visibility settings that control which components are displayed in the data label.
  /// </summary>
  /// <remarks>
  ///   Data label visibility settings allow selective display of different information types such as the
  ///   data value, category name, series name, percentage, legend key, or bubble size. This enables
  ///   customization of what information appears in each label, balancing informativeness with clarity.
  ///   For example, a label might show only the value, or it might show the value with the category name,
  ///   or even combine multiple pieces of information separated by the specified separator.
  /// </remarks>
  public DataLabelVisibilities? DataLabelVisibilities { get; set; }

  /// <summary>
  ///   Gets or sets the separator string used between multiple label components when displayed together.
  /// </summary>
  /// <remarks>
  ///   The separator determines how multiple pieces of information are delimited when a data label displays
  ///   more than one component (such as both value and category name). Common separators include commas,
  ///   hyphens, spaces, or newline characters. For example, with a comma separator, a label might display
  ///   "Category A, 100" or with a newline separator, it might display "Category A" on one line and "100"
  ///   on the next line. The choice of separator affects label readability and compactness.
  /// </remarks>
  public string? SeparatorXsdString { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <remarks>
  ///   Extension elements allow for future enhancements to data label functionality without breaking
  ///   compatibility with existing implementations. This could include additional positioning options,
  ///   formatting capabilities, or interactive features introduced in future versions.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}