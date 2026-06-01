namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Pivot Format.
/// </summary>
public class PivotFormat: ModelElement
{
  /// <summary>
  ///   IIndex.
  /// </summary>
  public UInt32? IIndex { get; set; }

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
  public IDataLabel? IDataLabel { get; set; }

  /// <summary>
  ///   IChart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
