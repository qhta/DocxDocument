namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the lighting rig configuration for 3D effects in a Wordprocessing drawing element.
/// This class provides properties for specifying the type and direction of the light rig, as well as sphere coordinates for advanced lighting control, enabling realistic rendering of 3D objects.
/// </summary>
[OpenXmlType(typeof(DXO10W.LightRig))]
public partial class LightRig: ModelElement<DXO10W.LightRig>
{
  /// <summary>
  /// The type of light rig used, defining the arrangement and style of lights applied to the 3D scene.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.LightRig.LightRigType))]
  public LightRigType? LightRigType
  {
    get => _LightRigType;
    set => UpdateField(ref _LightRigType, value, nameof(LightRigType));
  }
  private LightRigType? _LightRigType;
  /// <summary>
  /// The direction of the light rig, specifying the orientation of the lighting relative to the 3D object.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.LightRig.LightDirectionType))]
  public LightRigDirection? LightDirectionType
  {
    get => _LightDirectionType;
    set => UpdateField(ref _LightDirectionType, value, nameof(LightDirectionType));
  }
  private LightRigDirection? _LightDirectionType;
  /// <summary>
  /// The sphere coordinates for the light rig, allowing precise positioning of the light source in 3D space.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.LightRig.SphereCoordinates))]
  public SphereCoordinates? SphereCoordinates
  {
    get => _SphereCoordinates;
    set => UpdateField(ref _SphereCoordinates, value, nameof(SphereCoordinates));
  }
  private SphereCoordinates? _SphereCoordinates;
}