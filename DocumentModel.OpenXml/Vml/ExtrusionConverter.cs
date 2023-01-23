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
  
  private static bool CmpExtension(DXVmlO.Extrusion openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpOn(DXVmlO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.On?.Value == value;
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
  
  private static bool CmpType(DXVmlO.Extrusion openXmlElement, DMVml.ExtrusionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DMVml.ExtrusionKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpRender(DXVmlO.Extrusion openXmlElement, DMVml.ExtrusionRenderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DMVml.ExtrusionRenderKind>(openXmlElement?.Render?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpViewpointOrigin(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ViewpointOrigin?.Value == value;
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
  
  private static bool CmpViewpoint(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Viewpoint?.Value == value;
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
  
  private static bool CmpSkewAngle(DXVmlO.Extrusion openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.SkewAngle?.Value == value;
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
  
  private static bool CmpSkewAmount(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SkewAmount?.Value == value;
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
  
  private static bool CmpForceDepth(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ForceDepth?.Value == value;
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
  
  private static bool CmpBackDepth(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BackDepth?.Value == value;
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
  
  private static bool CmpOrientation(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Orientation?.Value == value;
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
  
  private static bool CmpOrientationAngle(DXVmlO.Extrusion openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.OrientationAngle?.Value == value;
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
  
  private static bool CmpLockRotationCenter(DXVmlO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LockRotationCenter?.Value == value;
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
  
  private static bool CmpAutoRotationCenter(DXVmlO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AutoRotationCenter?.Value == value;
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
  
  private static bool CmpRotationCenter(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RotationCenter?.Value == value;
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
  
  private static bool CmpRotationAngle(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RotationAngle?.Value == value;
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
  
  private static bool CmpColor(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Color?.Value == value;
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
  
  private static bool CmpShininess(DXVmlO.Extrusion openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Shininess?.Value == value;
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
  
  private static bool CmpSpecularity(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Specularity?.Value == value;
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
  
  private static bool CmpDiffusity(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Diffusity?.Value == value;
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
  
  private static bool CmpMetal(DXVmlO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Metal?.Value == value;
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
  
  private static bool CmpEdge(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Edge?.Value == value;
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
  
  private static bool CmpFacet(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Facet?.Value == value;
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
  
  private static bool CmpLightFace(DXVmlO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LightFace?.Value == value;
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
  
  private static bool CmpBrightness(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Brightness?.Value == value;
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
  
  private static bool CmpLightPosition(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LightPosition?.Value == value;
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
  
  private static bool CmpLightLevel(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LightLevel?.Value == value;
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
  
  private static bool CmpLightHarsh(DXVmlO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LightHarsh?.Value == value;
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
  
  private static bool CmpLightPosition2(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LightPosition2?.Value == value;
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
  
  private static bool CmpLightLevel2(DXVmlO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LightLevel2?.Value == value;
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
  
  private static bool CmpLightHarsh2(DXVmlO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LightHarsh2?.Value == value;
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
  
  public static bool CompareModelElement(DXVmlO.Extrusion? openXmlElement, DMVml.Extrusion? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpRender(openXmlElement, value.Render, diffs, objName))
        ok = false;
      if (!CmpViewpointOrigin(openXmlElement, value.ViewpointOrigin, diffs, objName))
        ok = false;
      if (!CmpViewpoint(openXmlElement, value.Viewpoint, diffs, objName))
        ok = false;
      if (!CmpSkewAngle(openXmlElement, value.SkewAngle, diffs, objName))
        ok = false;
      if (!CmpSkewAmount(openXmlElement, value.SkewAmount, diffs, objName))
        ok = false;
      if (!CmpForceDepth(openXmlElement, value.ForceDepth, diffs, objName))
        ok = false;
      if (!CmpBackDepth(openXmlElement, value.BackDepth, diffs, objName))
        ok = false;
      if (!CmpOrientation(openXmlElement, value.Orientation, diffs, objName))
        ok = false;
      if (!CmpOrientationAngle(openXmlElement, value.OrientationAngle, diffs, objName))
        ok = false;
      if (!CmpLockRotationCenter(openXmlElement, value.LockRotationCenter, diffs, objName))
        ok = false;
      if (!CmpAutoRotationCenter(openXmlElement, value.AutoRotationCenter, diffs, objName))
        ok = false;
      if (!CmpRotationCenter(openXmlElement, value.RotationCenter, diffs, objName))
        ok = false;
      if (!CmpRotationAngle(openXmlElement, value.RotationAngle, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpShininess(openXmlElement, value.Shininess, diffs, objName))
        ok = false;
      if (!CmpSpecularity(openXmlElement, value.Specularity, diffs, objName))
        ok = false;
      if (!CmpDiffusity(openXmlElement, value.Diffusity, diffs, objName))
        ok = false;
      if (!CmpMetal(openXmlElement, value.Metal, diffs, objName))
        ok = false;
      if (!CmpEdge(openXmlElement, value.Edge, diffs, objName))
        ok = false;
      if (!CmpFacet(openXmlElement, value.Facet, diffs, objName))
        ok = false;
      if (!CmpLightFace(openXmlElement, value.LightFace, diffs, objName))
        ok = false;
      if (!CmpBrightness(openXmlElement, value.Brightness, diffs, objName))
        ok = false;
      if (!CmpLightPosition(openXmlElement, value.LightPosition, diffs, objName))
        ok = false;
      if (!CmpLightLevel(openXmlElement, value.LightLevel, diffs, objName))
        ok = false;
      if (!CmpLightHarsh(openXmlElement, value.LightHarsh, diffs, objName))
        ok = false;
      if (!CmpLightPosition2(openXmlElement, value.LightPosition2, diffs, objName))
        ok = false;
      if (!CmpLightLevel2(openXmlElement, value.LightLevel2, diffs, objName))
        ok = false;
      if (!CmpLightHarsh2(openXmlElement, value.LightHarsh2, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
