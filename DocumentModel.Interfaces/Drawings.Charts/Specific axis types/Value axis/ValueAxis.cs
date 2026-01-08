namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a value axis for a chart, including crossing behavior, major and minor units, display units, and extension list.
/// </summary>
public interface ValueAxis : AxisType
{
  /// <summary>
  ///   Specifies how the axis crosses between categories or data points.
  /// </summary>
  public CrossBetweenKind? CrossBetween { get; set; }

  /// <summary>
  ///   Major unit value for the axis.
  /// </summary>
  public Double? MajorUnit { get; set; }

  /// <summary>
  ///   Minor unit value for the axis.
  /// </summary>
  public Double? MinorUnit { get; set; }

  /// <summary>
  ///   Display units configuration for the axis.
  /// </summary>
  public DisplayUnits? DisplayUnits { get; set; }

  /// <summary>
  ///   Extension list for additional value axis properties.
  /// </summary>
  public ValAxExtensionList? ValAxExtensionList { get; set; }
}