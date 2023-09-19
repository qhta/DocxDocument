namespace DocumentModel.Vml.Office;


/// <summary>
///   3D Extrusion.
/// </summary>
public partial class Extrusion
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  [SchemaAttr("on")]
  public Boolean? On { get; set; }
  
  
  /// <summary>
  ///   Extrusion Type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Vml.Office.ExtrusionValues? Type { get; set; }
  
  
  /// <summary>
  ///   Extrusion Render Mode
  /// </summary>
  [SchemaAttr("render")]
  public DocumentModel.Vml.Office.ExtrusionRenderValues? Render { get; set; }
  
  
  /// <summary>
  ///   Extrusion Viewpoint Origin
  /// </summary>
  [SchemaAttr("viewpointorigin")]
  public String? ViewpointOrigin { get; set; }
  
  
  /// <summary>
  ///   Extrusion Viewpoint
  /// </summary>
  [SchemaAttr("viewpoint")]
  public String? Viewpoint { get; set; }
  
  
  /// <summary>
  ///   Extrusion Skew Angle
  /// </summary>
  [SchemaAttr("skewangle")]
  public Single? SkewAngle { get; set; }
  
  
  /// <summary>
  ///   Extrusion Skew
  /// </summary>
  [SchemaAttr("skewamt")]
  public String? SkewAmount { get; set; }
  
  
  /// <summary>
  ///   Forward Extrusion
  /// </summary>
  [SchemaAttr("foredepth")]
  public String? ForceDepth { get; set; }
  
  
  /// <summary>
  ///   Backward Extrusion Depth
  /// </summary>
  [SchemaAttr("backdepth")]
  public String? BackDepth { get; set; }
  
  
  /// <summary>
  ///   Rotation Axis
  /// </summary>
  [SchemaAttr("orientation")]
  public String? Orientation { get; set; }
  
  
  /// <summary>
  ///   Rotation Around Axis
  /// </summary>
  [SchemaAttr("orientationangle")]
  public Single? OrientationAngle { get; set; }
  
  
  /// <summary>
  ///   Rotation Toggle
  /// </summary>
  [SchemaAttr("lockrotationcenter")]
  public Boolean? LockRotationCenter { get; set; }
  
  
  /// <summary>
  ///   Center of Rotation Toggle
  /// </summary>
  [SchemaAttr("autorotationcenter")]
  public Boolean? AutoRotationCenter { get; set; }
  
  
  /// <summary>
  ///   Rotation Center
  /// </summary>
  [SchemaAttr("rotationcenter")]
  public String? RotationCenter { get; set; }
  
  
  /// <summary>
  ///   X-Y Rotation Angle
  /// </summary>
  [SchemaAttr("rotationangle")]
  public String? RotationAngle { get; set; }
  
  
  /// <summary>
  ///   Extrusion Color
  /// </summary>
  [SchemaAttr("color")]
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Shininess
  /// </summary>
  [SchemaAttr("shininess")]
  public Single? Shininess { get; set; }
  
  
  /// <summary>
  ///   Specularity
  /// </summary>
  [SchemaAttr("specularity")]
  public String? Specularity { get; set; }
  
  
  /// <summary>
  ///   Diffuse Reflection
  /// </summary>
  [SchemaAttr("diffusity")]
  public String? Diffusity { get; set; }
  
  
  /// <summary>
  ///   Metallic Surface Toggle
  /// </summary>
  [SchemaAttr("metal")]
  public Boolean? Metal { get; set; }
  
  
  /// <summary>
  ///   Simulated Bevel
  /// </summary>
  [SchemaAttr("edge")]
  public String? Edge { get; set; }
  
  
  /// <summary>
  ///   Faceting Quality
  /// </summary>
  [SchemaAttr("facet")]
  public String? Facet { get; set; }
  
  
  /// <summary>
  ///   Shape Face Lighting Toggle
  /// </summary>
  [SchemaAttr("lightface")]
  public Boolean? LightFace { get; set; }
  
  
  /// <summary>
  ///   Brightness
  /// </summary>
  [SchemaAttr("brightness")]
  public String? Brightness { get; set; }
  
  
  /// <summary>
  ///   Primary Light Position
  /// </summary>
  [SchemaAttr("lightposition")]
  public String? LightPosition { get; set; }
  
  
  /// <summary>
  ///   Primary Light Intensity
  /// </summary>
  [SchemaAttr("lightlevel")]
  public String? LightLevel { get; set; }
  
  
  /// <summary>
  ///   Primary Light Harshness Toggle
  /// </summary>
  [SchemaAttr("lightharsh")]
  public Boolean? LightHarsh { get; set; }
  
  
  /// <summary>
  ///   Secondary Light Position
  /// </summary>
  [SchemaAttr("lightposition2")]
  public String? LightPosition2 { get; set; }
  
  
  /// <summary>
  ///   Secondary Light Intensity
  /// </summary>
  [SchemaAttr("lightlevel2")]
  public String? LightLevel2 { get; set; }
  
  
  /// <summary>
  ///   Secondary Light Harshness Toggle
  /// </summary>
  [SchemaAttr("lightharsh2")]
  public Boolean? LightHarsh2 { get; set; }
  
}
