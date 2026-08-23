namespace DocumentModel.Drawings;

/// <summary>
///   Represents hidden 3D scene properties, including camera, lighting, and backdrop configuration.
/// </summary>
[OpenXmlType(typeof(DXO10D.HiddenScene3D))]
[DataContract]
[XmlRoot("HiddenScene3D", Namespace = "DocumentModel.Drawings")]
public partial class HiddenScene3D: ModelElement<DXO10D.HiddenScene3D>, IExtendableElement
{
  /// <summary>
  ///   Camera settings for the hidden 3D scene.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.HiddenScene3D.Camera))]
  public Camera? Camera
  {
    get => _Camera ??= GetProperty<Camera?>(GetUpdatableElement()?.Camera);
    set => UpdateField(ref _Camera, value, nameof(Camera));
  }
  private Camera? _Camera;

  /// <summary>
  ///   Light rig configuration for the hidden 3D scene.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.HiddenScene3D.LightRig))]
  public LightRig? LightRig
  {
    get => _LightRig ??= GetProperty<LightRig?>(GetUpdatableElement()?.LightRig);
    set => UpdateField(ref _LightRig, value, nameof(LightRig));
  }
  private LightRig? _LightRig;

  /// <summary>
  ///   Backdrop plane for the hidden 3D scene.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.HiddenScene3D.Backdrop))]
  public Backdrop? Backdrop
  {
    get => _Backdrop ??= GetProperty<Backdrop?>(GetUpdatableElement()?.Backdrop);
    set => UpdateField(ref _Backdrop, value, nameof(Backdrop));
  }
  private Backdrop? _Backdrop;

  /// <summary>
  /// List of extension elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.HiddenScene3D.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<ExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}