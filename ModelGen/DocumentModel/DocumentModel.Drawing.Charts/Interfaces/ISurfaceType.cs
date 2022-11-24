namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public interface ISurfaceType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Thickness.
  /// </summary>
  public IThickness? Thickness { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
