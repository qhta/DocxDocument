namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// 3D Extrusion.
/// </summary>
public static class ExtrusionConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.Extrusion openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName);
  }
  
  private static void SetExtension(DXVO.Extrusion openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  private static Boolean? GetOn(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  private static DMV.ExtrusionKind? GetType(DXVO.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DMV.ExtrusionKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVO.Extrusion openXmlElement, DMV.ExtrusionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DMV.ExtrusionKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXVO.Extrusion openXmlElement, DMV.ExtrusionKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DMV.ExtrusionKind>(value);
  }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  private static DMV.ExtrusionRenderKind? GetRender(DXVO.Extrusion openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DMV.ExtrusionRenderKind>(openXmlElement?.Render?.Value);
  }
  
  private static bool CmpRender(DXVO.Extrusion openXmlElement, DMV.ExtrusionRenderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DMV.ExtrusionRenderKind>(openXmlElement?.Render?.Value, value, diffs, objName);
  }
  
  private static void SetRender(DXVO.Extrusion openXmlElement, DMV.ExtrusionRenderKind? value)
  {
    openXmlElement.Render = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DMV.ExtrusionRenderKind>(value);
  }
  
  /// <summary>
  /// Extrusion Viewpoint Origin
  /// </summary>
  private static String? GetViewpointOrigin(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ViewpointOrigin);
  }
  
  private static bool CmpViewpointOrigin(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ViewpointOrigin, value, diffs, objName, "ViewpointOrigin");
  }
  
  private static void SetViewpointOrigin(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.ViewpointOrigin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  private static String? GetViewpoint(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Viewpoint);
  }
  
  private static bool CmpViewpoint(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Viewpoint, value, diffs, objName, "Viewpoint");
  }
  
  private static void SetViewpoint(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.Viewpoint = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  private static Single? GetSkewAngle(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.SkewAngle?.Value;
  }
  
  private static bool CmpSkewAngle(DXVO.Extrusion openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SkewAngle?.Value == value) return true;
    diffs?.Add(objName, "SkewAngle", openXmlElement?.SkewAngle?.Value, value);
    return false;
  }
  
  private static void SetSkewAngle(DXVO.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.SkewAngle = value;
  }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  private static String? GetSkewAmount(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SkewAmount);
  }
  
  private static bool CmpSkewAmount(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SkewAmount, value, diffs, objName, "SkewAmount");
  }
  
  private static void SetSkewAmount(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.SkewAmount = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  private static String? GetForceDepth(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ForceDepth);
  }
  
  private static bool CmpForceDepth(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ForceDepth, value, diffs, objName, "ForceDepth");
  }
  
  private static void SetForceDepth(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.ForceDepth = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  private static String? GetBackDepth(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BackDepth);
  }
  
  private static bool CmpBackDepth(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BackDepth, value, diffs, objName, "BackDepth");
  }
  
  private static void SetBackDepth(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.BackDepth = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  private static String? GetOrientation(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Orientation);
  }
  
  private static bool CmpOrientation(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Orientation, value, diffs, objName, "Orientation");
  }
  
  private static void SetOrientation(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.Orientation = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  private static Single? GetOrientationAngle(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.OrientationAngle?.Value;
  }
  
  private static bool CmpOrientationAngle(DXVO.Extrusion openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OrientationAngle?.Value == value) return true;
    diffs?.Add(objName, "OrientationAngle", openXmlElement?.OrientationAngle?.Value, value);
    return false;
  }
  
  private static void SetOrientationAngle(DXVO.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.OrientationAngle = value;
  }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  private static Boolean? GetLockRotationCenter(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.LockRotationCenter?.Value;
  }
  
  private static bool CmpLockRotationCenter(DXVO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LockRotationCenter?.Value == value) return true;
    diffs?.Add(objName, "LockRotationCenter", openXmlElement?.LockRotationCenter?.Value, value);
    return false;
  }
  
  private static void SetLockRotationCenter(DXVO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockRotationCenter = value;
    else
      openXmlElement.LockRotationCenter = null;
  }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  private static Boolean? GetAutoRotationCenter(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.AutoRotationCenter?.Value;
  }
  
  private static bool CmpAutoRotationCenter(DXVO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AutoRotationCenter?.Value == value) return true;
    diffs?.Add(objName, "AutoRotationCenter", openXmlElement?.AutoRotationCenter?.Value, value);
    return false;
  }
  
  private static void SetAutoRotationCenter(DXVO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoRotationCenter = value;
    else
      openXmlElement.AutoRotationCenter = null;
  }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  private static String? GetRotationCenter(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RotationCenter);
  }
  
  private static bool CmpRotationCenter(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RotationCenter, value, diffs, objName, "RotationCenter");
  }
  
  private static void SetRotationCenter(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.RotationCenter = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  private static String? GetRotationAngle(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RotationAngle);
  }
  
  private static bool CmpRotationAngle(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RotationAngle, value, diffs, objName, "RotationAngle");
  }
  
  private static void SetRotationAngle(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.RotationAngle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  private static String? GetColor(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shininess
  /// </summary>
  private static Single? GetShininess(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.Shininess?.Value;
  }
  
  private static bool CmpShininess(DXVO.Extrusion openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Shininess?.Value == value) return true;
    diffs?.Add(objName, "Shininess", openXmlElement?.Shininess?.Value, value);
    return false;
  }
  
  private static void SetShininess(DXVO.Extrusion openXmlElement, Single? value)
  {
    openXmlElement.Shininess = value;
  }
  
  /// <summary>
  /// Specularity
  /// </summary>
  private static String? GetSpecularity(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Specularity);
  }
  
  private static bool CmpSpecularity(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Specularity, value, diffs, objName, "Specularity");
  }
  
  private static void SetSpecularity(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.Specularity = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  private static String? GetDiffusity(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Diffusity);
  }
  
  private static bool CmpDiffusity(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Diffusity, value, diffs, objName, "Diffusity");
  }
  
  private static void SetDiffusity(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.Diffusity = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  private static Boolean? GetMetal(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.Metal?.Value;
  }
  
  private static bool CmpMetal(DXVO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Metal?.Value == value) return true;
    diffs?.Add(objName, "Metal", openXmlElement?.Metal?.Value, value);
    return false;
  }
  
  private static void SetMetal(DXVO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Metal = value;
    else
      openXmlElement.Metal = null;
  }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  private static String? GetEdge(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Edge);
  }
  
  private static bool CmpEdge(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Edge, value, diffs, objName, "Edge");
  }
  
  private static void SetEdge(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.Edge = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  private static String? GetFacet(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Facet);
  }
  
  private static bool CmpFacet(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Facet, value, diffs, objName, "Facet");
  }
  
  private static void SetFacet(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.Facet = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  private static Boolean? GetLightFace(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightFace?.Value;
  }
  
  private static bool CmpLightFace(DXVO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LightFace?.Value == value) return true;
    diffs?.Add(objName, "LightFace", openXmlElement?.LightFace?.Value, value);
    return false;
  }
  
  private static void SetLightFace(DXVO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightFace = value;
    else
      openXmlElement.LightFace = null;
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  private static String? GetBrightness(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Brightness);
  }
  
  private static bool CmpBrightness(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Brightness, value, diffs, objName, "Brightness");
  }
  
  private static void SetBrightness(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.Brightness = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  private static String? GetLightPosition(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LightPosition);
  }
  
  private static bool CmpLightPosition(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LightPosition, value, diffs, objName, "LightPosition");
  }
  
  private static void SetLightPosition(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.LightPosition = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  private static String? GetLightLevel(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LightLevel);
  }
  
  private static bool CmpLightLevel(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LightLevel, value, diffs, objName, "LightLevel");
  }
  
  private static void SetLightLevel(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.LightLevel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  private static Boolean? GetLightHarsh(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightHarsh?.Value;
  }
  
  private static bool CmpLightHarsh(DXVO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LightHarsh?.Value == value) return true;
    diffs?.Add(objName, "LightHarsh", openXmlElement?.LightHarsh?.Value, value);
    return false;
  }
  
  private static void SetLightHarsh(DXVO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightHarsh = value;
    else
      openXmlElement.LightHarsh = null;
  }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  private static String? GetLightPosition2(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LightPosition2);
  }
  
  private static bool CmpLightPosition2(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LightPosition2, value, diffs, objName, "LightPosition2");
  }
  
  private static void SetLightPosition2(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.LightPosition2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  private static String? GetLightLevel2(DXVO.Extrusion openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LightLevel2);
  }
  
  private static bool CmpLightLevel2(DXVO.Extrusion openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LightLevel2, value, diffs, objName, "LightLevel2");
  }
  
  private static void SetLightLevel2(DXVO.Extrusion openXmlElement, String? value)
  {
    openXmlElement.LightLevel2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  private static Boolean? GetLightHarsh2(DXVO.Extrusion openXmlElement)
  {
    return openXmlElement?.LightHarsh2?.Value;
  }
  
  private static bool CmpLightHarsh2(DXVO.Extrusion openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LightHarsh2?.Value == value) return true;
    diffs?.Add(objName, "LightHarsh2", openXmlElement?.LightHarsh2?.Value, value);
    return false;
  }
  
  private static void SetLightHarsh2(DXVO.Extrusion openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LightHarsh2 = value;
    else
      openXmlElement.LightHarsh2 = null;
  }
  
  public static DocumentModel.Vml.Extrusion? CreateModelElement(DXVO.Extrusion? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.Extrusion? openXmlElement, DMV.Extrusion? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Extrusion value)
    where OpenXmlElementType: DXVO.Extrusion, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Extrusion openXmlElement, DMV.Extrusion value)
  {
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
  }
}
