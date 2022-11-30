namespace DocumentModel.Drawing;

/// <summary>
/// Backdrop Plane.
/// </summary>
public interface IBackdrop // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.IAnchor? Anchor { get ; set; }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public DocumentModel.Drawing.IVector3DType? Normal { get ; set; }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  public DocumentModel.Drawing.IVector3DType? UpVector { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
