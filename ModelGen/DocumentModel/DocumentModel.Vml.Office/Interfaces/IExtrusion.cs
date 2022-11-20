namespace DocumentModel.Vml.Office;

/// <summary>
/// 3D Extrusion.
/// </summary>
public interface IExtrusion // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public ITrueFalseValue? On { get ; set; }
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  public ExtrusionValues? Type { get ; set; }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  public ExtrusionRenderValues? Render { get ; set; }
  
  /// <summary>
  /// Extrusion Viewpoint Origin
  /// </summary>
  public string? ViewpointOrigin { get ; set; }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  public string? Viewpoint { get ; set; }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  public float? SkewAngle { get ; set; }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  public string? SkewAmount { get ; set; }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  public string? ForceDepth { get ; set; }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  public string? BackDepth { get ; set; }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  public string? Orientation { get ; set; }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  public float? OrientationAngle { get ; set; }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  public ITrueFalseValue? LockRotationCenter { get ; set; }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  public ITrueFalseValue? AutoRotationCenter { get ; set; }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  public string? RotationCenter { get ; set; }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  public string? RotationAngle { get ; set; }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  public string? Color { get ; set; }
  
  /// <summary>
  /// Shininess
  /// </summary>
  public float? Shininess { get ; set; }
  
  /// <summary>
  /// Specularity
  /// </summary>
  public string? Specularity { get ; set; }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  public string? Diffusity { get ; set; }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  public ITrueFalseValue? Metal { get ; set; }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  public string? Edge { get ; set; }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  public string? Facet { get ; set; }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  public ITrueFalseValue? LightFace { get ; set; }
  
  /// <summary>
  /// Brightness
  /// </summary>
  public string? Brightness { get ; set; }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  public string? LightPosition { get ; set; }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  public string? LightLevel { get ; set; }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  public ITrueFalseValue? LightHarsh { get ; set; }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  public string? LightPosition2 { get ; set; }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  public string? LightLevel2 { get ; set; }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  public ITrueFalseValue? LightHarsh2 { get ; set; }
  
}
