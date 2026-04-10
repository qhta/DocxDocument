using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the 3D scene settings for a drawing element in a Wordprocessing document.
/// This class provides properties for configuring the camera and lighting rig, enabling advanced 3D rendering and visualization of graphical objects.
/// </summary>
[OpenXmlType(typeof(DXO10W.Scene3D))]
[XmlRoot("Scene3D", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class Scene3D : ModelElement<DXO10W.Scene3D>, IDrawingProperty
{
 /// <summary>
 /// The camera settings for the 3D scene, specifying position, orientation, and perspective for rendering.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Scene3D.Camera))]
 public Camera? Camera { get => _Camera; set => UpdateField(ref _Camera, value, nameof(Camera)); }

 private Camera? _Camera;
 /// <summary>
 /// The lighting rig configuration for the 3D scene, defining the arrangement and properties of lights used for illumination.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Scene3D.LightRig))]
 public LightRig? LightRig { get => _LightRig; set => UpdateField(ref _LightRig, value, nameof(LightRig)); }

 private LightRig? _LightRig;
}