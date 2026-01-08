namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a data label for a chart data point or series, with extended configuration options.
///   Data labels display values, names, or other information directly on the chart, providing context and clarity for the data being visualized.
///   This interface allows advanced configuration of label content, formatting, position, and display options.
/// </summary>
public interface DataLabel3
{
  /// <summary>
  ///   Index of the data label within the series or collection.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Indicates whether the data label is deleted and should not be displayed.
  /// </summary>
  public bool? Delete { get; set; }

  /// <summary>
  ///   Layout configuration for the data label, controlling its position and alignment.
  /// </summary>
  public Layout? Layout { get; set; }

  /// <summary>
  ///   Text content and formatting for the data label.
  /// </summary>
  public ChartText? ChartText { get; set; }

  /// <summary>
  ///   Number format applied to the value displayed in the data label.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Visual and shape properties for the data label.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Text formatting and style properties for the data label.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Position of the data label relative to the data point.
  /// </summary>
  public DataLabelPositionKind? DataLabelPosition { get; set; }

  /// <summary>
  ///   Indicates whether the legend key is shown in the data label.
  /// </summary>
  public bool? ShowLegendKey { get; set; }

  /// <summary>
  ///   Indicates whether the value is shown in the data label.
  /// </summary>
  public bool? ShowValue { get; set; }

  /// <summary>
  ///   Indicates whether the category name is shown in the data label.
  /// </summary>
  public bool? ShowCategoryName { get; set; }

  /// <summary>
  ///   Indicates whether the series name is shown in the data label.
  /// </summary>
  public bool? ShowSeriesName { get; set; }

  /// <summary>
  ///   Indicates whether the percentage value is shown in the data label.
  /// </summary>
  public bool? ShowPercent { get; set; }

  /// <summary>
  ///   Indicates whether the bubble size is shown in the data label (for bubble charts).
  /// </summary>
  public bool? ShowBubbleSize { get; set; }

  /// <summary>
  ///   Separator string used between different parts of the data label content.
  /// </summary>
  public string? Separator { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional data label customization.
  /// </summary>
  public DLblExtensionList? DLblExtensionList { get; set; }
}