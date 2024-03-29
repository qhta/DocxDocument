namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Pivot Format.
/// </summary>
public class PivotFormat: ModelElement
{
  /// <summary>
  ///   Index.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Marker.
  /// </summary>
  public Marker? Marker { get; set; }

  /// <summary>
  ///   Data Label.
  /// </summary>
  public DataLabel? DataLabel { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}