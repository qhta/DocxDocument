namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Marker.
/// </summary>
public class Marker: ModelElement
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