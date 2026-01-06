using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Scene3D Class.
/// </summary>
public interface Scene3D: ITypedModelElement, DrawingProperty
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