namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Scene3D Class.
/// </summary>
public class Scene3D: ModelElement
{
  /// <summary>
  ///   Camera.
  /// </summary>
  public Camera? Camera { get; set; }

  /// <summary>
  ///   LightRig.
  /// </summary>
  public LightRig? LightRig { get; set; }
}