namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Light Rig.
/// </summary>
public class LightRig: ModelElement
{
  /// <summary>
  ///   Rig Preset
  /// </summary>
  public LightRigKind? Rig { get; set; }

  /// <summary>
  ///   Direction
  /// </summary>
  public LightRigDirectionKind? Direction { get; set; }

  /// <summary>
  ///   Rotation.
  /// </summary>
  public Rotation? Rotation { get; set; }
}
