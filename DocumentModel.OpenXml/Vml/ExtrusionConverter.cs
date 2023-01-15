using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using Extrusion = DocumentFormat.OpenXml.Vml.Office.Extrusion;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   3D Extrusion.
/// </summary>
public static class ExtrusionConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(Extrusion? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(Extrusion? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  public static Boolean? GetOn(Extrusion? openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }

  public static void SetOn(Extrusion? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.On = value;
      else
        openXmlElement.On = null;
  }

  /// <summary>
  ///   Extrusion Type
  /// </summary>
  public static ExtrusionKind? GetType(Extrusion? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtrusionValues, ExtrusionKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Extrusion? openXmlElement, ExtrusionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<ExtrusionValues, ExtrusionKind>(value);
  }

  /// <summary>
  ///   Extrusion Render Mode
  /// </summary>
  public static ExtrusionRenderKind? GetRender(Extrusion? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtrusionRenderValues, ExtrusionRenderKind>(openXmlElement?.Render?.Value);
  }

  public static void SetRender(Extrusion? openXmlElement, ExtrusionRenderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Render = EnumValueConverter.CreateEnumValue<ExtrusionRenderValues, ExtrusionRenderKind>(value);
  }

  /// <summary>
  ///   Extrusion Viewpoint Origin
  /// </summary>
  public static String? GetViewpointOrigin(Extrusion? openXmlElement)
  {
    return openXmlElement?.ViewpointOrigin?.Value;
  }

  public static void SetViewpointOrigin(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ViewpointOrigin = new StringValue { Value = value };
      else
        openXmlElement.ViewpointOrigin = null;
  }

  /// <summary>
  ///   Extrusion Viewpoint
  /// </summary>
  public static String? GetViewpoint(Extrusion? openXmlElement)
  {
    return openXmlElement?.Viewpoint?.Value;
  }

  public static void SetViewpoint(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Viewpoint = new StringValue { Value = value };
      else
        openXmlElement.Viewpoint = null;
  }

  /// <summary>
  ///   Extrusion Skew Angle
  /// </summary>
  public static Single? GetSkewAngle(Extrusion? openXmlElement)
  {
    return openXmlElement?.SkewAngle?.Value;
  }

  public static void SetSkewAngle(Extrusion? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.SkewAngle = value;
  }

  /// <summary>
  ///   Extrusion Skew
  /// </summary>
  public static String? GetSkewAmount(Extrusion? openXmlElement)
  {
    return openXmlElement?.SkewAmount?.Value;
  }

  public static void SetSkewAmount(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SkewAmount = new StringValue { Value = value };
      else
        openXmlElement.SkewAmount = null;
  }

  /// <summary>
  ///   Forward Extrusion
  /// </summary>
  public static String? GetForceDepth(Extrusion? openXmlElement)
  {
    return openXmlElement?.ForceDepth?.Value;
  }

  public static void SetForceDepth(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForceDepth = new StringValue { Value = value };
      else
        openXmlElement.ForceDepth = null;
  }

  /// <summary>
  ///   Backward Extrusion Depth
  /// </summary>
  public static String? GetBackDepth(Extrusion? openXmlElement)
  {
    return openXmlElement?.BackDepth?.Value;
  }

  public static void SetBackDepth(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BackDepth = new StringValue { Value = value };
      else
        openXmlElement.BackDepth = null;
  }

  /// <summary>
  ///   Rotation Axis
  /// </summary>
  public static String? GetOrientation(Extrusion? openXmlElement)
  {
    return openXmlElement?.Orientation?.Value;
  }

  public static void SetOrientation(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Orientation = new StringValue { Value = value };
      else
        openXmlElement.Orientation = null;
  }

  /// <summary>
  ///   Rotation Around Axis
  /// </summary>
  public static Single? GetOrientationAngle(Extrusion? openXmlElement)
  {
    return openXmlElement?.OrientationAngle?.Value;
  }

  public static void SetOrientationAngle(Extrusion? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.OrientationAngle = value;
  }

  /// <summary>
  ///   Rotation Toggle
  /// </summary>
  public static Boolean? GetLockRotationCenter(Extrusion? openXmlElement)
  {
    return openXmlElement?.LockRotationCenter?.Value;
  }

  public static void SetLockRotationCenter(Extrusion? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LockRotationCenter = value;
      else
        openXmlElement.LockRotationCenter = null;
  }

  /// <summary>
  ///   Center of Rotation Toggle
  /// </summary>
  public static Boolean? GetAutoRotationCenter(Extrusion? openXmlElement)
  {
    return openXmlElement?.AutoRotationCenter?.Value;
  }

  public static void SetAutoRotationCenter(Extrusion? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AutoRotationCenter = value;
      else
        openXmlElement.AutoRotationCenter = null;
  }

  /// <summary>
  ///   Rotation Center
  /// </summary>
  public static String? GetRotationCenter(Extrusion? openXmlElement)
  {
    return openXmlElement?.RotationCenter?.Value;
  }

  public static void SetRotationCenter(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotationCenter = new StringValue { Value = value };
      else
        openXmlElement.RotationCenter = null;
  }

  /// <summary>
  ///   X-Y Rotation Angle
  /// </summary>
  public static String? GetRotationAngle(Extrusion? openXmlElement)
  {
    return openXmlElement?.RotationAngle?.Value;
  }

  public static void SetRotationAngle(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotationAngle = new StringValue { Value = value };
      else
        openXmlElement.RotationAngle = null;
  }

  /// <summary>
  ///   Extrusion Color
  /// </summary>
  public static String? GetColor(Extrusion? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }

  public static void SetColor(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }

  /// <summary>
  ///   Shininess
  /// </summary>
  public static Single? GetShininess(Extrusion? openXmlElement)
  {
    return openXmlElement?.Shininess?.Value;
  }

  public static void SetShininess(Extrusion? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.Shininess = value;
  }

  /// <summary>
  ///   Specularity
  /// </summary>
  public static String? GetSpecularity(Extrusion? openXmlElement)
  {
    return openXmlElement?.Specularity?.Value;
  }

  public static void SetSpecularity(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Specularity = new StringValue { Value = value };
      else
        openXmlElement.Specularity = null;
  }

  /// <summary>
  ///   Diffuse Reflection
  /// </summary>
  public static String? GetDiffusity(Extrusion? openXmlElement)
  {
    return openXmlElement?.Diffusity?.Value;
  }

  public static void SetDiffusity(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Diffusity = new StringValue { Value = value };
      else
        openXmlElement.Diffusity = null;
  }

  /// <summary>
  ///   Metallic Surface Toggle
  /// </summary>
  public static Boolean? GetMetal(Extrusion? openXmlElement)
  {
    return openXmlElement?.Metal?.Value;
  }

  public static void SetMetal(Extrusion? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Metal = value;
      else
        openXmlElement.Metal = null;
  }

  /// <summary>
  ///   Simulated Bevel
  /// </summary>
  public static String? GetEdge(Extrusion? openXmlElement)
  {
    return openXmlElement?.Edge?.Value;
  }

  public static void SetEdge(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Edge = new StringValue { Value = value };
      else
        openXmlElement.Edge = null;
  }

  /// <summary>
  ///   Faceting Quality
  /// </summary>
  public static String? GetFacet(Extrusion? openXmlElement)
  {
    return openXmlElement?.Facet?.Value;
  }

  public static void SetFacet(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Facet = new StringValue { Value = value };
      else
        openXmlElement.Facet = null;
  }

  /// <summary>
  ///   Shape Face Lighting Toggle
  /// </summary>
  public static Boolean? GetLightFace(Extrusion? openXmlElement)
  {
    return openXmlElement?.LightFace?.Value;
  }

  public static void SetLightFace(Extrusion? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightFace = value;
      else
        openXmlElement.LightFace = null;
  }

  /// <summary>
  ///   Brightness
  /// </summary>
  public static String? GetBrightness(Extrusion? openXmlElement)
  {
    return openXmlElement?.Brightness?.Value;
  }

  public static void SetBrightness(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Brightness = new StringValue { Value = value };
      else
        openXmlElement.Brightness = null;
  }

  /// <summary>
  ///   Primary Light Position
  /// </summary>
  public static String? GetLightPosition(Extrusion? openXmlElement)
  {
    return openXmlElement?.LightPosition?.Value;
  }

  public static void SetLightPosition(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightPosition = new StringValue { Value = value };
      else
        openXmlElement.LightPosition = null;
  }

  /// <summary>
  ///   Primary Light Intensity
  /// </summary>
  public static String? GetLightLevel(Extrusion? openXmlElement)
  {
    return openXmlElement?.LightLevel?.Value;
  }

  public static void SetLightLevel(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightLevel = new StringValue { Value = value };
      else
        openXmlElement.LightLevel = null;
  }

  /// <summary>
  ///   Primary Light Harshness Toggle
  /// </summary>
  public static Boolean? GetLightHarsh(Extrusion? openXmlElement)
  {
    return openXmlElement?.LightHarsh?.Value;
  }

  public static void SetLightHarsh(Extrusion? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightHarsh = value;
      else
        openXmlElement.LightHarsh = null;
  }

  /// <summary>
  ///   Secondary Light Position
  /// </summary>
  public static String? GetLightPosition2(Extrusion? openXmlElement)
  {
    return openXmlElement?.LightPosition2?.Value;
  }

  public static void SetLightPosition2(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightPosition2 = new StringValue { Value = value };
      else
        openXmlElement.LightPosition2 = null;
  }

  /// <summary>
  ///   Secondary Light Intensity
  /// </summary>
  public static String? GetLightLevel2(Extrusion? openXmlElement)
  {
    return openXmlElement?.LightLevel2?.Value;
  }

  public static void SetLightLevel2(Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightLevel2 = new StringValue { Value = value };
      else
        openXmlElement.LightLevel2 = null;
  }

  /// <summary>
  ///   Secondary Light Harshness Toggle
  /// </summary>
  public static Boolean? GetLightHarsh2(Extrusion? openXmlElement)
  {
    return openXmlElement?.LightHarsh2?.Value;
  }

  public static void SetLightHarsh2(Extrusion? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightHarsh2 = value;
      else
        openXmlElement.LightHarsh2 = null;
  }

  public static DocumentModel.Vml.Extrusion? CreateModelElement(Extrusion? openXmlElement)
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
    where OpenXmlElementType : Extrusion, new()
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