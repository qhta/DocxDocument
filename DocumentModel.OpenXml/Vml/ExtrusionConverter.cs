namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// 3D Extrusion.
/// </summary>
public static class ExtrusionConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  private static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  private static DocumentModel.Vml.ExtrusionKind? GetType(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DocumentModel.Vml.ExtrusionKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, DocumentModel.Vml.ExtrusionKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DocumentModel.Vml.ExtrusionKind>(value);
  }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  private static DocumentModel.Vml.ExtrusionRenderKind? GetRender(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DocumentModel.Vml.ExtrusionRenderKind>(openXmlElement?.Render?.Value);
  }
  
  private static void SetRender(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, DocumentModel.Vml.ExtrusionRenderKind? value)
  {
    openXmlElement.Render = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DocumentModel.Vml.ExtrusionRenderKind>(value);
  }
  
  /// <summary>
  /// Extrusion Viewpoint Origin
  /// </summary>
  private static String? GetViewpointOrigin(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.ViewpointOrigin?.Value;
  }
  
  private static void SetViewpointOrigin(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ViewpointOrigin = new StringValue { Value = value };
    else
      openXmlElement.ViewpointOrigin = null;
  }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  private static String? GetViewpoint(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Viewpoint?.Value;
  }
  
  private static void SetViewpoint(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Viewpoint = new StringValue { Value = value };
    else
      openXmlElement.Viewpoint = null;
  }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  private static Single? GetSkewAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement.SkewAngle?.Value;
  }
  
  private static void SetSkewAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.SkewAngle = value;
  }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  private static String? GetSkewAmount(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.SkewAmount?.Value;
  }
  
  private static void SetSkewAmount(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SkewAmount = new StringValue { Value = value };
    else
      openXmlElement.SkewAmount = null;
  }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  private static String? GetForceDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.ForceDepth?.Value;
  }
  
  private static void SetForceDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ForceDepth = new StringValue { Value = value };
    else
      openXmlElement.ForceDepth = null;
  }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  private static String? GetBackDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.BackDepth?.Value;
  }
  
  private static void SetBackDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BackDepth = new StringValue { Value = value };
    else
      openXmlElement.BackDepth = null;
  }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  private static String? GetOrientation(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Orientation?.Value;
  }
  
  private static void SetOrientation(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Orientation = new StringValue { Value = value };
    else
      openXmlElement.Orientation = null;
  }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  private static Single? GetOrientationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement.OrientationAngle?.Value;
  }
  
  private static void SetOrientationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.OrientationAngle = value;
  }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  private static Boolean? GetLockRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.LockRotationCenter?.Value;
  }
  
  private static void SetLockRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockRotationCenter = value;
    else
      openXmlElement.LockRotationCenter = null;
  }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  private static Boolean? GetAutoRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.AutoRotationCenter?.Value;
  }
  
  private static void SetAutoRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoRotationCenter = value;
    else
      openXmlElement.AutoRotationCenter = null;
  }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  private static String? GetRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.RotationCenter?.Value;
  }
  
  private static void SetRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RotationCenter = new StringValue { Value = value };
    else
      openXmlElement.RotationCenter = null;
  }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  private static String? GetRotationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.RotationAngle?.Value;
  }
  
  private static void SetRotationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RotationAngle = new StringValue { Value = value };
    else
      openXmlElement.RotationAngle = null;
  }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  private static String? GetColor(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Shininess
  /// </summary>
  private static Single? GetShininess(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement.Shininess?.Value;
  }
  
  private static void SetShininess(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.Shininess = value;
  }
  
  /// <summary>
  /// Specularity
  /// </summary>
  private static String? GetSpecularity(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Specularity?.Value;
  }
  
  private static void SetSpecularity(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Specularity = new StringValue { Value = value };
    else
      openXmlElement.Specularity = null;
  }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  private static String? GetDiffusity(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Diffusity?.Value;
  }
  
  private static void SetDiffusity(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Diffusity = new StringValue { Value = value };
    else
      openXmlElement.Diffusity = null;
  }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  private static Boolean? GetMetal(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Metal?.Value;
  }
  
  private static void SetMetal(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Metal = value;
    else
      openXmlElement.Metal = null;
  }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  private static String? GetEdge(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Edge?.Value;
  }
  
  private static void SetEdge(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Edge = new StringValue { Value = value };
    else
      openXmlElement.Edge = null;
  }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  private static String? GetFacet(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Facet?.Value;
  }
  
  private static void SetFacet(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Facet = new StringValue { Value = value };
    else
      openXmlElement.Facet = null;
  }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  private static Boolean? GetLightFace(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.LightFace?.Value;
  }
  
  private static void SetLightFace(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightFace = value;
    else
      openXmlElement.LightFace = null;
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  private static String? GetBrightness(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.Brightness?.Value;
  }
  
  private static void SetBrightness(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Brightness = new StringValue { Value = value };
    else
      openXmlElement.Brightness = null;
  }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  private static String? GetLightPosition(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.LightPosition?.Value;
  }
  
  private static void SetLightPosition(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LightPosition = new StringValue { Value = value };
    else
      openXmlElement.LightPosition = null;
  }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  private static String? GetLightLevel(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.LightLevel?.Value;
  }
  
  private static void SetLightLevel(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LightLevel = new StringValue { Value = value };
    else
      openXmlElement.LightLevel = null;
  }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  private static Boolean? GetLightHarsh(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.LightHarsh?.Value;
  }
  
  private static void SetLightHarsh(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightHarsh = value;
    else
      openXmlElement.LightHarsh = null;
  }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  private static String? GetLightPosition2(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.LightPosition2?.Value;
  }
  
  private static void SetLightPosition2(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LightPosition2 = new StringValue { Value = value };
    else
      openXmlElement.LightPosition2 = null;
  }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  private static String? GetLightLevel2(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.LightLevel2?.Value;
  }
  
  private static void SetLightLevel2(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LightLevel2 = new StringValue { Value = value };
    else
      openXmlElement.LightLevel2 = null;
  }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  private static Boolean? GetLightHarsh2(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement)
  {
    return openXmlElement?.LightHarsh2?.Value;
  }
  
  private static void SetLightHarsh2(DocumentFormat.OpenXml.Vml.Office.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightHarsh2 = value;
    else
      openXmlElement.LightHarsh2 = null;
  }
  
  public static DocumentModel.Vml.Extrusion? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Extrusion();
      value.Extension = GetExtension(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Render = GetRender(openXmlElement);
      value.ViewpointOrigin = GetViewpointOrigin(openXmlElement);
      value.Viewpoint = GetViewpoint(openXmlElement);
      value.SkewAngle = GetSkewAngle(openXmlElement);
      value.SkewAmount = GetSkewAmount(openXmlElement);
      value.ForceDepth = GetForceDepth(openXmlElement);
      value.BackDepth = GetBackDepth(openXmlElement);
      value.Orientation = GetOrientation(openXmlElement);
      value.OrientationAngle = GetOrientationAngle(openXmlElement);
      value.LockRotationCenter = GetLockRotationCenter(openXmlElement);
      value.AutoRotationCenter = GetAutoRotationCenter(openXmlElement);
      value.RotationCenter = GetRotationCenter(openXmlElement);
      value.RotationAngle = GetRotationAngle(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Shininess = GetShininess(openXmlElement);
      value.Specularity = GetSpecularity(openXmlElement);
      value.Diffusity = GetDiffusity(openXmlElement);
      value.Metal = GetMetal(openXmlElement);
      value.Edge = GetEdge(openXmlElement);
      value.Facet = GetFacet(openXmlElement);
      value.LightFace = GetLightFace(openXmlElement);
      value.Brightness = GetBrightness(openXmlElement);
      value.LightPosition = GetLightPosition(openXmlElement);
      value.LightLevel = GetLightLevel(openXmlElement);
      value.LightHarsh = GetLightHarsh(openXmlElement);
      value.LightPosition2 = GetLightPosition2(openXmlElement);
      value.LightLevel2 = GetLightLevel2(openXmlElement);
      value.LightHarsh2 = GetLightHarsh2(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Extrusion? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Extrusion, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetOn(openXmlElement, value?.On);
      SetType(openXmlElement, value?.Type);
      SetRender(openXmlElement, value?.Render);
      SetViewpointOrigin(openXmlElement, value?.ViewpointOrigin);
      SetViewpoint(openXmlElement, value?.Viewpoint);
      SetSkewAngle(openXmlElement, value?.SkewAngle);
      SetSkewAmount(openXmlElement, value?.SkewAmount);
      SetForceDepth(openXmlElement, value?.ForceDepth);
      SetBackDepth(openXmlElement, value?.BackDepth);
      SetOrientation(openXmlElement, value?.Orientation);
      SetOrientationAngle(openXmlElement, value?.OrientationAngle);
      SetLockRotationCenter(openXmlElement, value?.LockRotationCenter);
      SetAutoRotationCenter(openXmlElement, value?.AutoRotationCenter);
      SetRotationCenter(openXmlElement, value?.RotationCenter);
      SetRotationAngle(openXmlElement, value?.RotationAngle);
      SetColor(openXmlElement, value?.Color);
      SetShininess(openXmlElement, value?.Shininess);
      SetSpecularity(openXmlElement, value?.Specularity);
      SetDiffusity(openXmlElement, value?.Diffusity);
      SetMetal(openXmlElement, value?.Metal);
      SetEdge(openXmlElement, value?.Edge);
      SetFacet(openXmlElement, value?.Facet);
      SetLightFace(openXmlElement, value?.LightFace);
      SetBrightness(openXmlElement, value?.Brightness);
      SetLightPosition(openXmlElement, value?.LightPosition);
      SetLightLevel(openXmlElement, value?.LightLevel);
      SetLightHarsh(openXmlElement, value?.LightHarsh);
      SetLightPosition2(openXmlElement, value?.LightPosition2);
      SetLightLevel2(openXmlElement, value?.LightLevel2);
      SetLightHarsh2(openXmlElement, value?.LightHarsh2);
      return openXmlElement;
    }
    return default;
  }
}
