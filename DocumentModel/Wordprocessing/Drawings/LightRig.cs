namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LightRig Class.
/// </summary>
public class LightRig: ModelElement
{
  /// <summary>
  ///   rig, this property is only available in Office 2010 and later.
  /// </summary>
  public LightRigKind? LightRigType { get; set; }

  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  public LightRigDirectionKind? LightDirectionType { get; set; }

  /// <summary>
  ///   SphereCoordinates.
  /// </summary>
  public SphereCoordinates? SphereCoordinates { get; set; }
}