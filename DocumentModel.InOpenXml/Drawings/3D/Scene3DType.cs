namespace DocumentModel.Drawings;
/// <summary>
///   Defines properties for a 3D scene, including camera, lighting, and backdrop configuration.
/// </summary>
[OpenXmlType(typeof(DXD.Scene3DType))]
public partial class Scene3DType : ModelElement<DXD.Scene3DType>, IExtendableElement
{
 /// <summary>
 ///   Camera settings for the 3-D scene.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Scene3DType.Camera))]
 public Camera? Camera { get => _Camera; set => UpdateField(ref _Camera, value, nameof(Camera)); }
 private Camera? _Camera;
 /// <summary>
 ///   Light rig configuration for the 3-D scene.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Scene3DType.LightRig))]
 public LightRig? LightRig { get => _LightRig; set => UpdateField(ref _LightRig, value, nameof(LightRig)); }
 private LightRig? _LightRig;
 /// <summary>
 ///   Backdrop plane for the 3-D scene.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Scene3DType.Backdrop))]
 public Backdrop? Backdrop { get => _Backdrop; set => UpdateField(ref _Backdrop, value, nameof(Backdrop)); }
 private Backdrop? _Backdrop;
 /// <summary>
 /// List of extension elements.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Scene3DType.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}