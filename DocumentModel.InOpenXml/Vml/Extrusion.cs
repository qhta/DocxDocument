namespace DocumentModel.Vml;
/// <summary>
///   3D Extrusion.
/// </summary>
public partial class Extrusion : ModelElement<DXVO.Extrusion>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Extrusion Toggle
    /// </summary>
    public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

    private bool? _On;
    /// <summary>
    ///   Extrusion Type
    /// </summary>
    public ExtrusionKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private ExtrusionKind? _Type;
    /// <summary>
    ///   Extrusion Render Mode
    /// </summary>
    public ExtrusionRenderKind? Render { get => _Render; set => UpdateField(ref _Render, value, nameof(Render)); }

    private ExtrusionRenderKind? _Render;
    /// <summary>
    ///   Extrusion Viewpoint Origin
    /// </summary>
    public string? ViewpointOrigin { get => _ViewpointOrigin; set => UpdateField(ref _ViewpointOrigin, value, nameof(ViewpointOrigin)); }

    private string? _ViewpointOrigin;
    /// <summary>
    ///   Extrusion Viewpoint
    /// </summary>
    public string? Viewpoint { get => _Viewpoint; set => UpdateField(ref _Viewpoint, value, nameof(Viewpoint)); }

    private string? _Viewpoint;
    /// <summary>
    ///   Extrusion Skew Angle
    /// </summary>
    public Single? SkewAngle { get => _SkewAngle; set => UpdateField(ref _SkewAngle, value, nameof(SkewAngle)); }

    private Single? _SkewAngle;
    /// <summary>
    ///   Extrusion Skew
    /// </summary>
    public string? SkewAmount { get => _SkewAmount; set => UpdateField(ref _SkewAmount, value, nameof(SkewAmount)); }

    private string? _SkewAmount;
    /// <summary>
    ///   Forward Extrusion
    /// </summary>
    public string? ForceDepth { get => _ForceDepth; set => UpdateField(ref _ForceDepth, value, nameof(ForceDepth)); }

    private string? _ForceDepth;
    /// <summary>
    ///   Backward Extrusion Depth
    /// </summary>
    public string? BackDepth { get => _BackDepth; set => UpdateField(ref _BackDepth, value, nameof(BackDepth)); }

    private string? _BackDepth;
    /// <summary>
    ///   Rotation Axis
    /// </summary>
    public string? Orientation { get => _Orientation; set => UpdateField(ref _Orientation, value, nameof(Orientation)); }

    private string? _Orientation;
    /// <summary>
    ///   Rotation Around Axis
    /// </summary>
    public Single? OrientationAngle { get => _OrientationAngle; set => UpdateField(ref _OrientationAngle, value, nameof(OrientationAngle)); }

    private Single? _OrientationAngle;
    /// <summary>
    ///   Rotation Toggle
    /// </summary>
    public bool? LockRotationCenter { get => _LockRotationCenter; set => UpdateField(ref _LockRotationCenter, value, nameof(LockRotationCenter)); }

    private bool? _LockRotationCenter;
    /// <summary>
    ///   Center of Rotation Toggle
    /// </summary>
    public bool? AutoRotationCenter { get => _AutoRotationCenter; set => UpdateField(ref _AutoRotationCenter, value, nameof(AutoRotationCenter)); }

    private bool? _AutoRotationCenter;
    /// <summary>
    ///   Rotation Center
    /// </summary>
    public string? RotationCenter { get => _RotationCenter; set => UpdateField(ref _RotationCenter, value, nameof(RotationCenter)); }

    private string? _RotationCenter;
    /// <summary>
    ///   X-Y Rotation Angle
    /// </summary>
    public string? RotationAngle { get => _RotationAngle; set => UpdateField(ref _RotationAngle, value, nameof(RotationAngle)); }

    private string? _RotationAngle;
    /// <summary>
    ///   Extrusion Color
    /// </summary>
    public string? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

    private string? _Color;
    /// <summary>
    ///   Shininess
    /// </summary>
    public Single? Shininess { get => _Shininess; set => UpdateField(ref _Shininess, value, nameof(Shininess)); }

    private Single? _Shininess;
    /// <summary>
    ///   Specularity
    /// </summary>
    public string? Specularity { get => _Specularity; set => UpdateField(ref _Specularity, value, nameof(Specularity)); }

    private string? _Specularity;
    /// <summary>
    ///   Diffuse Reflection
    /// </summary>
    public string? Diffusity { get => _Diffusity; set => UpdateField(ref _Diffusity, value, nameof(Diffusity)); }

    private string? _Diffusity;
    /// <summary>
    ///   Metallic Surface Toggle
    /// </summary>
    public bool? Metal { get => _Metal; set => UpdateField(ref _Metal, value, nameof(Metal)); }

    private bool? _Metal;
    /// <summary>
    ///   Simulated Bevel
    /// </summary>
    public string? Edge { get => _Edge; set => UpdateField(ref _Edge, value, nameof(Edge)); }

    private string? _Edge;
    /// <summary>
    ///   Faceting Quality
    /// </summary>
    public string? Facet { get => _Facet; set => UpdateField(ref _Facet, value, nameof(Facet)); }

    private string? _Facet;
    /// <summary>
    ///   Shape Face Lighting Toggle
    /// </summary>
    public bool? LightFace { get => _LightFace; set => UpdateField(ref _LightFace, value, nameof(LightFace)); }

    private bool? _LightFace;
    /// <summary>
    ///   Brightness
    /// </summary>
    public string? Brightness { get => _Brightness; set => UpdateField(ref _Brightness, value, nameof(Brightness)); }

    private string? _Brightness;
    /// <summary>
    ///   Primary Light Position
    /// </summary>
    public string? LightPosition { get => _LightPosition; set => UpdateField(ref _LightPosition, value, nameof(LightPosition)); }

    private string? _LightPosition;
    /// <summary>
    ///   Primary Light Intensity
    /// </summary>
    public string? LightLevel { get => _LightLevel; set => UpdateField(ref _LightLevel, value, nameof(LightLevel)); }

    private string? _LightLevel;
    /// <summary>
    ///   Primary Light Harshness Toggle
    /// </summary>
    public bool? LightHarsh { get => _LightHarsh; set => UpdateField(ref _LightHarsh, value, nameof(LightHarsh)); }

    private bool? _LightHarsh;
    /// <summary>
    ///   Secondary Light Position
    /// </summary>
    public string? LightPosition2 { get => _LightPosition2; set => UpdateField(ref _LightPosition2, value, nameof(LightPosition2)); }

    private string? _LightPosition2;
    /// <summary>
    ///   Secondary Light Intensity
    /// </summary>
    public string? LightLevel2 { get => _LightLevel2; set => UpdateField(ref _LightLevel2, value, nameof(LightLevel2)); }

    private string? _LightLevel2;
    /// <summary>
    ///   Secondary Light Harshness Toggle
    /// </summary>
    public bool? LightHarsh2 { get => _LightHarsh2; set => UpdateField(ref _LightHarsh2, value, nameof(LightHarsh2)); }

    private bool? _LightHarsh2;
}