namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Backdrop Plane.
/// </summary>
public class Backdrop: ModelElement
{
  /// <summary>
  ///   Anchor Point.
  /// </summary>
  public Anchor? Anchor { get; set; }

  /// <summary>
  ///   Normal.
  /// </summary>
  public Vector3DType? Normal { get; set; }

  /// <summary>
  ///   Up Vector.
  /// </summary>
  public Vector3DType? UpVector { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}