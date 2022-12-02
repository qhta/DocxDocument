namespace DocumentModel.Drawing;

/// <summary>
/// Pivot Format.
/// </summary>
public interface IPivotFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawing.IMarker? Marker { get ; set; }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  public DocumentModel.Drawing.IDataLabel? DataLabel { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
