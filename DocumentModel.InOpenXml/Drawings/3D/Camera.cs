namespace DocumentModel.Drawings;
/// <summary>
/// Camera settings for 3D effects in drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.Camera))]
[DataContract]
[XmlRoot("Camera", Namespace = "DocumentModel.Drawings")]
public partial class Camera : ModelElement<DXD.Camera>
{
 /// <summary>
 /// Preset camera type.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Camera.Preset))]
 public PresetCamera? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }
 private PresetCamera? _Preset;

 /// <summary>
 /// Field of view.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Camera.FieldOfView))]
 public Int32? FieldOfView { get => _FieldOfView; set => UpdateField(ref _FieldOfView, value, nameof(FieldOfView)); }
 private Int32? _FieldOfView;

 /// <summary>
 /// Zoom factor.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Camera.Zoom))]
 public Int32? Zoom { get => _Zoom; set => UpdateField(ref _Zoom, value, nameof(Zoom)); }
 private Int32? _Zoom;

 /// <summary>
 /// Camera rotation.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Camera.Rotation))]
 public Rotation? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }
 private Rotation? _Rotation;
}