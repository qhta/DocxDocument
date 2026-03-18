namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a collection of data labels for a chart series or data points.
///   Data labels display values, names, or other information directly on the chart, providing context and clarity for the data being visualized.
///   This class allows configuration of label formatting, display options, and additional label features.
/// </summary>
public class DataLabels : ModelElementCollection<DataLabel>
{
  /// <summary>
  ///   Indicates whether all data labels are deleted and should not be displayed.
  /// </summary>
  public bool? Delete { get; set; }

  /// <summary>
  ///   Number format applied to the values displayed in the data labels.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Visual and shape properties for the data labels.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Text formatting and style properties for the data labels.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Position of the data labels relative to the data points.
  /// </summary>
  public DataLabelPosition? DataLabelPosition { get; set; }

  /// <summary>
  ///   Indicates whether the legend key is shown in the data labels.
  /// </summary>
  public bool? ShowLegendKey { get; set; }

  /// <summary>
  ///   Indicates whether the value is shown in the data labels.
  /// </summary>
  public bool? ShowValue { get; set; }

  /// <summary>
  ///   Indicates whether the category name is shown in the data labels.
  /// </summary>
  public bool? ShowCategoryName { get; set; }

  /// <summary>
  ///   Indicates whether the series name is shown in the data labels.
  /// </summary>
  public bool? ShowSeriesName { get; set; }

  /// <summary>
  ///   Indicates whether the percentage value is shown in the data labels.
  /// </summary>
  public bool? ShowPercent { get; set; }

  /// <summary>
  ///   Indicates whether the bubble size is shown in the data labels (for bubble charts).
  /// </summary>
  public bool? ShowBubbleSize { get; set; }

  /// <summary>
  ///   Separator string used between different parts of the data label content.
  /// </summary>
  public string? Separator { get; set; }

  /// <summary>
  ///   Indicates whether leader lines are shown for the data labels.
  /// </summary>
  public bool? ShowLeaderLines { get; set; }

  /// <summary>
  ///   Leader lines configuration for the data labels.
  /// </summary>
  [OpenXmlIndirectElement(typeof(DXDC.LeaderLines), typeof(DXDC.ChartShapeProperties))]
  public ChartShapeProperties? LeaderLines { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional data label customization.
  /// </summary>
  public DLblsExtensionList? DLblsExtensionList { get; set; }
}