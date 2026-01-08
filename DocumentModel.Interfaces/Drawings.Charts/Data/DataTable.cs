namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a data table displayed within a chart.
///   A data table shows the underlying data values in a grid format below the chart, providing a clear view of the data used to generate the chart.
///   This interface allows configuration of border visibility, legend keys, and visual properties for the data table.
/// </summary>
public interface DataTable
{
  /// <summary>
  ///   Indicates whether horizontal borders are shown in the data table.
  /// </summary>
  public bool? ShowHorizontalBorder { get; set; }

  /// <summary>
  ///   Indicates whether vertical borders are shown in the data table.
  /// </summary>
  public bool? ShowVerticalBorder { get; set; }

  /// <summary>
  ///   Indicates whether an outline border is shown around the data table.
  /// </summary>
  public bool? ShowOutlineBorder { get; set; }

  /// <summary>
  ///   Indicates whether legend keys are displayed in the data table.
  /// </summary>
  public bool? ShowKeys { get; set; }

  /// <summary>
  ///   Visual and shape properties for the data table.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Text formatting and style properties for the data table.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional data table customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}