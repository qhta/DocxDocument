namespace DocumentModel.Vml.Office;

/// <summary>
/// 3D Extrusion.
/// </summary>
public interface IExtrusion // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public System.Boolean? On { get ; set; }
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  public DocumentModel.Vml.Office.ExtrusionKind? Type { get ; set; }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  public DocumentModel.Vml.Office.ExtrusionRenderKind? Render { get ; set; }
  
  /// <summary>
  /// Extrusion Viewpoint Origin
  /// </summary>
  public System.String? ViewpointOrigin { get ; set; }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  public System.String? Viewpoint { get ; set; }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  public System.Single? SkewAngle { get ; set; }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  public System.String? SkewAmount { get ; set; }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  public System.String? ForceDepth { get ; set; }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  public System.String? BackDepth { get ; set; }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  public System.String? Orientation { get ; set; }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  public System.Single? OrientationAngle { get ; set; }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  public System.Boolean? LockRotationCenter { get ; set; }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  public System.Boolean? AutoRotationCenter { get ; set; }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  public System.String? RotationCenter { get ; set; }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  public System.String? RotationAngle { get ; set; }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  public System.String? Color { get ; set; }
  
  /// <summary>
  /// Shininess
  /// </summary>
  public System.Single? Shininess { get ; set; }
  
  /// <summary>
  /// Specularity
  /// </summary>
  public System.String? Specularity { get ; set; }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  public System.String? Diffusity { get ; set; }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  public System.Boolean? Metal { get ; set; }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  public System.String? Edge { get ; set; }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  public System.String? Facet { get ; set; }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  public System.Boolean? LightFace { get ; set; }
  
  /// <summary>
  /// Brightness
  /// </summary>
  public System.String? Brightness { get ; set; }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  public System.String? LightPosition { get ; set; }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  public System.String? LightLevel { get ; set; }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  public System.Boolean? LightHarsh { get ; set; }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  public System.String? LightPosition2 { get ; set; }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  public System.String? LightLevel2 { get ; set; }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  public System.Boolean? LightHarsh2 { get ; set; }
  
}
