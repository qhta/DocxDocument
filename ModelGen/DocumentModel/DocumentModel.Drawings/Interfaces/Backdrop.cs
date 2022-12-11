namespace DocumentModel.Drawings;

/// <summary>
/// Backdrop Plane.
/// </summary>
public interface Backdrop
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public Anchor? Anchor { get ; set; }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public Vector3DType? Normal { get ; set; }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  public Vector3DType? UpVector { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
