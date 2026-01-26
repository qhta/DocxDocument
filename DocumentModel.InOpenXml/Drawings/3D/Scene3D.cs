namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Represents a 3-D scene, including camera, lighting, backdrop, and extension information.
/// </summary>
[OpenXmlType(typeof(DXO10W.Scene3D))]
public partial class Scene3D : ModelElement<DXO10W.Scene3D>, IExtendableElement
{
 /// <summary>
 ///   Camera settings for the 3-D scene.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Scene3D.Camera))]
 /// <summary>
 ///   Camera settings for the 3-D scene.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.Scene3D))]
 public Camera? Camera { get => _Camera; set => UpdateField(ref _Camera, value, nameof(Camera)); }

 private Camera? _Camera;
 /// <summary>
 ///   Light rig configuration for the 3-D scene.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Scene3D.LightRig))]
 /// <summary>
 ///   Light rig configuration for the 3-D scene.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.Scene3D))]
 public LightRig? LightRig { get => _LightRig; set => UpdateField(ref _LightRig, value, nameof(LightRig)); }

 private LightRig? _LightRig;
 /// <summary>
 ///   Backdrop plane for the 3-D scene.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.Scene3D))]
 public Backdrop? Backdrop { get => _Backdrop; set => UpdateField(ref _Backdrop, value, nameof(Backdrop)); }

 private Backdrop? _Backdrop;
 /// <summary>
 /// List of extension elements.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.Scene3D))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}