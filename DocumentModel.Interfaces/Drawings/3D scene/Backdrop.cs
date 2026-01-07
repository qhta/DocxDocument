namespace DocumentModel.Drawings;

/// <summary>
/// Represents a backdrop plane in 3D drawing space, defined by an anchor point, normal vector, and up vector.
/// </summary>
public interface Backdrop: ExtendableElement
{
  /// <summary>
  /// Anchor point of the backdrop plane.
  /// </summary>
  public Anchor? Anchor { get; set; }

  /// <summary>
  /// Normal vector of the backdrop plane.
  /// </summary>
  public Vector3DType? Normal { get; set; }

  /// <summary>
  /// Up vector of the backdrop plane.
  /// </summary>
  public Vector3DType? UpVector { get; set; }
}