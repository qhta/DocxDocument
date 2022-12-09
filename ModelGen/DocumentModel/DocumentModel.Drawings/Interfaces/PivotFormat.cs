namespace DocumentModel.Drawings;

/// <summary>
/// Pivot Format.
/// </summary>
public interface PivotFormat
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties5? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public Marker1? Marker { get ; set; }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  public DataLabel1? DataLabel { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList3? ExtensionList { get ; set; }
  
}
