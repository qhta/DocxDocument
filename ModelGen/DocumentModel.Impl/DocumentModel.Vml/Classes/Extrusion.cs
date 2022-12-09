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
    get => (Boolean?)OpenXmlElement?.On?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.On = (System.Boolean?)value;
    }
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
    get => (String?)OpenXmlElement?.ViewpointOrigin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ViewpointOrigin = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  public String? Viewpoint
  {
    get => (String?)OpenXmlElement?.Viewpoint?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Viewpoint = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  public Single? SkewAngle
  {
    get => (Single?)OpenXmlElement?.SkewAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SkewAngle = (System.Single?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  public String? SkewAmount
  {
    get => (String?)OpenXmlElement?.SkewAmount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SkewAmount = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  public String? ForceDepth
  {
    get => (String?)OpenXmlElement?.ForceDepth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ForceDepth = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  public String? BackDepth
  {
    get => (String?)OpenXmlElement?.BackDepth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BackDepth = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  public String? Orientation
  {
    get => (String?)OpenXmlElement?.Orientation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Orientation = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  public Single? OrientationAngle
  {
    get => (Single?)OpenXmlElement?.OrientationAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OrientationAngle = (System.Single?)value;
    }
  }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  public Boolean? LockRotationCenter
  {
    get => (Boolean?)OpenXmlElement?.LockRotationCenter?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LockRotationCenter = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  public Boolean? AutoRotationCenter
  {
    get => (Boolean?)OpenXmlElement?.AutoRotationCenter?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AutoRotationCenter = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  public String? RotationCenter
  {
    get => (String?)OpenXmlElement?.RotationCenter?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RotationCenter = (System.String?)value;
    }
  }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  public String? RotationAngle
  {
    get => (String?)OpenXmlElement?.RotationAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RotationAngle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  public String? Color
  {
    get => (String?)OpenXmlElement?.Color?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shininess
  /// </summary>
  public Single? Shininess
  {
    get => (Single?)OpenXmlElement?.Shininess?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Shininess = (System.Single?)value;
    }
  }
  
  /// <summary>
  /// Specularity
  /// </summary>
  public String? Specularity
  {
    get => (String?)OpenXmlElement?.Specularity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Specularity = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  public String? Diffusity
  {
    get => (String?)OpenXmlElement?.Diffusity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Diffusity = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  public Boolean? Metal
  {
    get => (Boolean?)OpenXmlElement?.Metal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Metal = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  public String? Edge
  {
    get => (String?)OpenXmlElement?.Edge?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Edge = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  public String? Facet
  {
    get => (String?)OpenXmlElement?.Facet?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Facet = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  public Boolean? LightFace
  {
    get => (Boolean?)OpenXmlElement?.LightFace?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightFace = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  public String? Brightness
  {
    get => (String?)OpenXmlElement?.Brightness?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Brightness = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  public String? LightPosition
  {
    get => (String?)OpenXmlElement?.LightPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightPosition = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  public String? LightLevel
  {
    get => (String?)OpenXmlElement?.LightLevel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightLevel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  public Boolean? LightHarsh
  {
    get => (Boolean?)OpenXmlElement?.LightHarsh?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightHarsh = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  public String? LightPosition2
  {
    get => (String?)OpenXmlElement?.LightPosition2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightPosition2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  public String? LightLevel2
  {
    get => (String?)OpenXmlElement?.LightLevel2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightLevel2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  public Boolean? LightHarsh2
  {
    get => (Boolean?)OpenXmlElement?.LightHarsh2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightHarsh2 = (System.Boolean?)value;
    }
  }
  
}
