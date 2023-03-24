namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HiddenScene3D Class.
/// </summary>
public class HiddenScene3D: ModelElement
{
  /// <summary>
  ///   Camera.
  /// </summary>
  public Camera? Camera { get; set; }

  /// <summary>
  ///   Light Rig.
  /// </summary>
  public LightRig? LightRig { get; set; }

  /// <summary>
  ///   Backdrop Plane.
  /// </summary>
  public Backdrop? Backdrop { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}