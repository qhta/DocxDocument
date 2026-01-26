namespace DocumentModel.Drawings;
/// <summary>
///   Represents a light rig configuration, including preset, direction, and rotation for 3D scenes or objects.
/// </summary>
[OpenXmlType(typeof(DXD.LightRig))]
public partial class LightRig : ModelElement<DXD.LightRig>
{
 /// <summary>
 ///   Preset type of the light rig.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.LightRig.Rig))]
 /// <summary>
 ///   Preset type of the light rig.
 /// </summary>
 [OpenXmlElement(typeof(DXD.LightRig))]
 public LightRigKind? Rig { get => _Rig; set => UpdateField(ref _Rig, value, nameof(Rig)); }

 private LightRigKind? _Rig;
 /// <summary>
 ///   Direction of the light rig.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.LightRig.Direction))]
 /// <summary>
 ///   Direction of the light rig.
 /// </summary>
 [OpenXmlElement(typeof(DXD.LightRig))]
 public LightRigDirectionKind? Direction { get => _Direction; set => UpdateField(ref _Direction, value, nameof(Direction)); }

 private LightRigDirectionKind? _Direction;
 /// <summary>
 ///   Rotation settings for the light rig.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.LightRig.Rotation))]
 /// <summary>
 ///   Rotation settings for the light rig.
 /// </summary>
 [OpenXmlElement(typeof(DXD.LightRig))]
 public Rotation? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

 private Rotation? _Rotation;
}