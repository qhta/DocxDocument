namespace DocumentModel.Drawings;

/// <summary>
/// Pivot Format.
/// </summary>
public class PivotFormat
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties1? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public Marker1? Marker
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  public DataLabel2? DataLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
