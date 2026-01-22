namespace DocumentModel.Drawings;
/// <summary>
///   Represents a light rig configuration, including preset, direction, and rotation for 3D scenes or objects.
/// </summary>
public partial class LightRig : ModelElement<DXD.LightRig>
{
    /// <summary>
    ///   Preset type of the light rig.
    /// </summary>
    public LightRigKind? Rig { get => _Rig; set => UpdateField(ref _Rig, value, nameof(Rig)); }

    private LightRigKind? _Rig;
    /// <summary>
    ///   Direction of the light rig.
    /// </summary>
    public LightRigDirectionKind? Direction { get; set; }
    /// <summary>
    ///   Rotation settings for the light rig.
    /// </summary>
    public Rotation? Rotation { get; set; }
}