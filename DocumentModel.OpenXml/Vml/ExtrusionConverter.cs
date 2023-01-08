namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// 3D Extrusion.
/// </summary>
public static class ExtrusionConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  public static DocumentModel.Vml.ExtrusionKind? GetType(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DocumentModel.Vml.ExtrusionKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, DocumentModel.Vml.ExtrusionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues, DocumentModel.Vml.ExtrusionKind>(value);
  }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  public static DocumentModel.Vml.ExtrusionRenderKind? GetRender(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DocumentModel.Vml.ExtrusionRenderKind>(openXmlElement?.Render?.Value);
  }
  
  public static void SetRender(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, DocumentModel.Vml.ExtrusionRenderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Render = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues, DocumentModel.Vml.ExtrusionRenderKind>(value);
  }
  
  /// <summary>
  /// Extrusion Viewpoint Origin
  /// </summary>
  public static String? GetViewpointOrigin(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetViewpointOrigin(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  public static String? GetViewpoint(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetViewpoint(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  public static Single? GetSkewAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSkewAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Single? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  public static String? GetSkewAmount(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSkewAmount(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  public static String? GetForceDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetForceDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  public static String? GetBackDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetBackDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  public static String? GetOrientation(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOrientation(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  public static Single? GetOrientationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOrientationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Single? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  public static Boolean? GetLockRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLockRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  public static Boolean? GetAutoRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAutoRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  public static String? GetRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  public static String? GetRotationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetRotationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shininess
  /// </summary>
  public static Single? GetShininess(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShininess(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Single? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Specularity
  /// </summary>
  public static String? GetSpecularity(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSpecularity(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  public static String? GetDiffusity(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetDiffusity(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  public static Boolean? GetMetal(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMetal(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  public static String? GetEdge(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetEdge(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  public static String? GetFacet(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFacet(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  public static Boolean? GetLightFace(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLightFace(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  public static String? GetBrightness(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetBrightness(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  public static String? GetLightPosition(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLightPosition(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  public static String? GetLightLevel(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLightLevel(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  public static Boolean? GetLightHarsh(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLightHarsh(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  public static String? GetLightPosition2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLightPosition2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  public static String? GetLightLevel2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLightLevel2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  public static Boolean? GetLightHarsh2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLightHarsh2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
