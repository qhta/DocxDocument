namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public interface ISurfaceType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Thickness.
  /// </summary>
  public System.Byte? Thickness { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public DocumentModel.Drawing.IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
