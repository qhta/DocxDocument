namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Marker.
/// </summary>
public record Marker
{
  /// <summary>
  ///   Symbol.
  /// </summary>
  public MarkerStyleKind? Symbol { get; set; }

  /// <summary>
  ///   Size.
  /// </summary>
  public Byte? Size { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}