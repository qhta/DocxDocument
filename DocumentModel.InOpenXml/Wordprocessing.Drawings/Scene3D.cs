using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the 3D scene settings for a drawing element in a Wordprocessing document.
/// This class provides properties for configuring the camera and lighting rig, enabling advanced 3D rendering and visualization of graphical objects.
/// </summary>
public partial class Scene3D : IDrawingProperty
{
  /// <summary>
  /// The camera settings for the 3D scene, specifying position, orientation, and perspective for rendering.
  /// </summary>
  public Camera? Camera { get; set; }
  /// <summary>
  /// The lighting rig configuration for the 3D scene, defining the arrangement and properties of lights used for illumination.
  /// </summary>
  public LightRig? LightRig { get; set; }
}