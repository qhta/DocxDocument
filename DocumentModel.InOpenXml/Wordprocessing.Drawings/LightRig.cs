namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the lighting rig configuration for 3D effects in a Wordprocessing drawing element.
/// This class provides properties for specifying the type and direction of the light rig, as well as sphere coordinates for advanced lighting control, enabling realistic rendering of 3D objects.
/// </summary>
public partial class LightRig : ModelElement
{
    /// <summary>
    /// The type of light rig used, defining the arrangement and style of lights applied to the 3D scene.
    /// </summary>
    public LightRigKind? LightRigType { get => _LightRigType; set => UpdateField(ref _LightRigType, value, nameof(LightRigType)); }

    private LightRigKind? _LightRigType;
    /// <summary>
    /// The direction of the light rig, specifying the orientation of the lighting relative to the 3D object.
    /// </summary>
    public LightRigDirectionKind? LightDirectionType { get => _LightDirectionType; set => UpdateField(ref _LightDirectionType, value, nameof(LightDirectionType)); }

    private LightRigDirectionKind? _LightDirectionType;
    /// <summary>
    /// The sphere coordinates for the light rig, allowing precise positioning of the light source in 3D space.
    /// </summary>
    public SphereCoordinates? SphereCoordinates { get => _SphereCoordinates; set => UpdateField(ref _SphereCoordinates, value, nameof(SphereCoordinates)); }

    private SphereCoordinates? _SphereCoordinates;
}