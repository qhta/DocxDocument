namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the plot area of a chart, including layout, chart collection, axes, data table, shape properties, and extension list.
/// </summary>
public interface PlotArea
{
  /// <summary>
  ///   Layout configuration for the plot area.
  /// </summary>
  public Layout? Layout { get; set; }

  /// <summary>
  ///   Collection of charts contained in the plot area.
  /// </summary>
  public Charts Charts { get; set; }

  /// <summary>
  ///   List of axes used in the plot area.
  /// </summary>
  public AxisList? Axes { get; set; }

  /// <summary>
  ///   Data table associated with the plot area.
  /// </summary>
  public DataTable? DataTable { get; set; }

  /// <summary>
  ///   Shape properties for the plot area.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Extension list for additional plot area properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}