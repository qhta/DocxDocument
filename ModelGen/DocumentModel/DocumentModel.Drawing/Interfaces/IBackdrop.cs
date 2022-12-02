namespace DocumentModel.Drawing;

/// <summary>
/// Backdrop Plane.
/// </summary>
public interface IBackdrop // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public IAnchor? Anchor { get ; set; }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public IVector3DType? Normal { get ; set; }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  public IVector3DType? UpVector { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
