namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the LightRig Class.
/// </summary>
public interface LightRig:
{
  /// <summary>
  ///   rig
  /// </summary>
  public LightRigKind? LightRigType { get; set; }
  /// <summary>
  ///   dir
  /// </summary>
  public LightRigDirectionKind? LightDirectionType { get; set; }
  /// <summary>
  ///   SphereCoordinates.
  /// </summary>
  public SphereCoordinates? SphereCoordinates { get; set; }
}