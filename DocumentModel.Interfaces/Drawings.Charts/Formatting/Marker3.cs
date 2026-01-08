namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a marker in a chart (version 3), typically for line or scatter charts.
///   This interface defines the visual appearance, size, and shape properties of the marker.
/// </summary>
public interface Marker3
{
  /// <summary>
  ///   Symbol style of the marker.
  /// </summary>
  public MarkerStyleKind? Symbol { get; set; }

  /// <summary>
  ///   Size of the marker.
  /// </summary>
  public Byte? Size { get; set; }

  /// <summary>
  ///   Visual and shape properties for the marker.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional marker customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}