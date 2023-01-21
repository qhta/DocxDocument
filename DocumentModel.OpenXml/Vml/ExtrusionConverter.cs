namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// 3D Extrusion.
/// </summary>
public static class ExtrusionConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.Extrusion openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  private static Boolean? GetOn(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DXVmlO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  private static DMVml.ExtrusionKind? GetType(DXVmlO.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DMVml.ExtrusionKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXVmlO.Extrusion openXmlElement, DMVml.ExtrusionKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DMVml.ExtrusionKind>(value);
  }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  private static DMVml.ExtrusionRenderKind? GetRender(DXVmlO.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DMVml.ExtrusionRenderKind>(openXmlElement?.Render?.Value);
  }
  
  private static void SetRender(DXVmlO.Extrusion openXmlElement, DMVml.ExtrusionRenderKind? value)
  {
    openXmlElement.Render = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DMVml.ExtrusionRenderKind>(value);
  }
  
  /// <summary>
  /// Extrusion Viewpoint Origin
  /// </summary>
  private static String? GetViewpointOrigin(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.ViewpointOrigin?.Value;
  }
  
  private static void SetViewpointOrigin(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ViewpointOrigin = new StringValue { Value = value };
    else
      openXmlElement.ViewpointOrigin = null;
  }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  private static String? GetViewpoint(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Viewpoint?.Value;
  }
  
  private static void SetViewpoint(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Viewpoint = new StringValue { Value = value };
    else
      openXmlElement.Viewpoint = null;
  }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  private static Single? GetSkewAngle(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement.SkewAngle?.Value;
  }
  
  private static void SetSkewAngle(DXVmlO.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.SkewAngle = value;
  }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  private static String? GetSkewAmount(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.SkewAmount?.Value;
  }
  
  private static void SetSkewAmount(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SkewAmount = new StringValue { Value = value };
    else
      openXmlElement.SkewAmount = null;
  }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  private static String? GetForceDepth(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.ForceDepth?.Value;
  }
  
  private static void SetForceDepth(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ForceDepth = new StringValue { Value = value };
    else
      openXmlElement.ForceDepth = null;
  }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  private static String? GetBackDepth(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.BackDepth?.Value;
  }
  
  private static void SetBackDepth(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BackDepth = new StringValue { Value = value };
    else
      openXmlElement.BackDepth = null;
  }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  private static String? GetOrientation(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Orientation?.Value;
  }
  
  private static void SetOrientation(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Orientation = new StringValue { Value = value };
    else
      openXmlElement.Orientation = null;
  }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  private static Single? GetOrientationAngle(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement.OrientationAngle?.Value;
  }
  
  private static void SetOrientationAngle(DXVmlO.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.OrientationAngle = value;
  }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  private static Boolean? GetLockRotationCenter(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.LockRotationCenter?.Value;
  }
  
  private static void SetLockRotationCenter(DXVmlO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockRotationCenter = value;
    else
      openXmlElement.LockRotationCenter = null;
  }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  private static Boolean? GetAutoRotationCenter(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.AutoRotationCenter?.Value;
  }
  
  private static void SetAutoRotationCenter(DXVmlO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoRotationCenter = value;
    else
      openXmlElement.AutoRotationCenter = null;
  }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  private static String? GetRotationCenter(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.RotationCenter?.Value;
  }
  
  private static void SetRotationCenter(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RotationCenter = new StringValue { Value = value };
    else
      openXmlElement.RotationCenter = null;
  }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  private static String? GetRotationAngle(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.RotationAngle?.Value;
  }
  
  private static void SetRotationAngle(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RotationAngle = new StringValue { Value = value };
    else
      openXmlElement.RotationAngle = null;
  }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  private static String? GetColor(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Shininess
  /// </summary>
  private static Single? GetShininess(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement.Shininess?.Value;
  }
  
  private static void SetShininess(DXVmlO.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.Shininess = value;
  }
  
  /// <summary>
  /// Specularity
  /// </summary>
  private static String? GetSpecularity(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Specularity?.Value;
  }
  
  private static void SetSpecularity(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Specularity = new StringValue { Value = value };
    else
      openXmlElement.Specularity = null;
  }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  private static String? GetDiffusity(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Diffusity?.Value;
  }
  
  private static void SetDiffusity(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Diffusity = new StringValue { Value = value };
    else
      openXmlElement.Diffusity = null;
  }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  private static Boolean? GetMetal(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Metal?.Value;
  }
  
  private static void SetMetal(DXVmlO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Metal = value;
    else
      openXmlElement.Metal = null;
  }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  private static String? GetEdge(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Edge?.Value;
  }
  
  private static void SetEdge(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Edge = new StringValue { Value = value };
    else
      openXmlElement.Edge = null;
  }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  private static String? GetFacet(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Facet?.Value;
  }
  
  private static void SetFacet(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Facet = new StringValue { Value = value };
    else
      openXmlElement.Facet = null;
  }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  private static Boolean? GetLightFace(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightFace?.Value;
  }
  
  private static void SetLightFace(DXVmlO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightFace = value;
    else
      openXmlElement.LightFace = null;
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  private static String? GetBrightness(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.Brightness?.Value;
  }
  
  private static void SetBrightness(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Brightness = new StringValue { Value = value };
    else
      openXmlElement.Brightness = null;
  }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  private static String? GetLightPosition(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightPosition?.Value;
  }
  
  private static void SetLightPosition(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LightPosition = new StringValue { Value = value };
    else
      openXmlElement.LightPosition = null;
  }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  private static String? GetLightLevel(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightLevel?.Value;
  }
  
  private static void SetLightLevel(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LightLevel = new StringValue { Value = value };
    else
      openXmlElement.LightLevel = null;
  }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  private static Boolean? GetLightHarsh(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightHarsh?.Value;
  }
  
  private static void SetLightHarsh(DXVmlO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightHarsh = value;
    else
      openXmlElement.LightHarsh = null;
  }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  private static String? GetLightPosition2(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightPosition2?.Value;
  }
  
  private static void SetLightPosition2(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LightPosition2 = new StringValue { Value = value };
    else
      openXmlElement.LightPosition2 = null;
  }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  private static String? GetLightLevel2(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightLevel2?.Value;
  }
  
  private static void SetLightLevel2(DXVmlO.Extrusion openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LightLevel2 = new StringValue { Value = value };
    else
      openXmlElement.LightLevel2 = null;
  }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  private static Boolean? GetLightHarsh2(DXVmlO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightHarsh2?.Value;
  }
  
  private static void SetLightHarsh2(DXVmlO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightHarsh2 = value;
    else
      openXmlElement.LightHarsh2 = null;
  }
  
  public static DMVml.Extrusion? CreateModelElement(DXVmlO.Extrusion? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Extrusion();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Extrusion? value)
    where OpenXmlElementType: DXVmlO.Extrusion, new()
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
