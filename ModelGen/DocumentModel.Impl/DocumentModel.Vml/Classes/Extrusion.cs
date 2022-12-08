namespace DocumentModel.Vml;

/// <summary>
/// 3D Extrusion.
/// </summary>
public class ExtrusionImpl: ModelElementImpl, Extrusion
{
  public DocumentFormat.OpenXml.Vml.Office.Extrusion? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Extrusion?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public Boolean? On
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  public ExtrusionKind? Type
  {
    get => (ExtrusionKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.ExtrusionValues?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  public ExtrusionRenderKind? Render
  {
    get => (ExtrusionRenderKind?)OpenXmlElement?.Render?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Render = (DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Viewpoint Origin
  /// </summary>
  public String? ViewpointOrigin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  public String? Viewpoint
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  public Single? SkewAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  public String? SkewAmount
  {
    get;
    set;
  }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  public String? ForceDepth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  public String? BackDepth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  public String? Orientation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  public Single? OrientationAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  public Boolean? LockRotationCenter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  public Boolean? AutoRotationCenter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  public String? RotationCenter
  {
    get;
    set;
  }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  public String? RotationAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  public String? Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shininess
  /// </summary>
  public Single? Shininess
  {
    get;
    set;
  }
  
  /// <summary>
  /// Specularity
  /// </summary>
  public String? Specularity
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  public String? Diffusity
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  public Boolean? Metal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  public String? Edge
  {
    get;
    set;
  }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  public String? Facet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  public Boolean? LightFace
  {
    get;
    set;
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  public String? Brightness
  {
    get;
    set;
  }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  public String? LightPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  public String? LightLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  public Boolean? LightHarsh
  {
    get;
    set;
  }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  public String? LightPosition2
  {
    get;
    set;
  }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  public String? LightLevel2
  {
    get;
    set;
  }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  public Boolean? LightHarsh2
  {
    get;
    set;
  }
  
}
