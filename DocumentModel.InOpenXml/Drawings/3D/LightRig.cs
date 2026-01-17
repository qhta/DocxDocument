namespace DocumentModel.Drawings;

/// <summary>
///   Represents a light rig configuration, including preset, direction, and rotation for 3D scenes or objects.
/// </summary>
public class LightRig: ModelElement<DXD.LightRig>
{
  /// <summary>
  ///   Preset type of the light rig.
  /// </summary>
  public LightRigKind? Rig { get; set; }

  /// <summary>
  ///   Direction of the light rig.
  /// </summary>
  public LightRigDirectionKind? Direction { get; set; }

  /// <summary>
  ///   Rotation settings for the light rig.
  /// </summary>
  public Rotation? Rotation { get; set; }
}