using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Scene3D Class.
/// </summary>
public class Scene3D: ITypedModelElement, IDrawingProperty
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