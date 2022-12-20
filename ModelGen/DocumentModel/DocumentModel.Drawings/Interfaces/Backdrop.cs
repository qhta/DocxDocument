namespace DocumentModel.Drawings;

/// <summary>
/// Backdrop Plane.
/// </summary>
public partial interface Backdrop
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public DocumentModel.Drawings.Anchor? Anchor { get; set; }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public DocumentModel.Drawings.Vector3DType? Normal { get; set; }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  public DocumentModel.Drawings.Vector3DType? UpVector { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
