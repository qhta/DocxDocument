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
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
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
    return openXmlElement?.ViewpointOrigin?.Value;
  }
  
  public static void SetViewpointOrigin(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ViewpointOrigin = new StringValue { Value = value };
      else
        openXmlElement.ViewpointOrigin = null;
  }
  
  /// <summary>
  /// Extrusion Viewpoint
  /// </summary>
  public static String? GetViewpoint(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Viewpoint?.Value;
  }
  
  public static void SetViewpoint(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Viewpoint = new StringValue { Value = value };
      else
        openXmlElement.Viewpoint = null;
  }
  
  /// <summary>
  /// Extrusion Skew Angle
  /// </summary>
  public static Single? GetSkewAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.SkewAngle?.Value;
  }
  
  public static void SetSkewAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.SkewAngle = value;
  }
  
  /// <summary>
  /// Extrusion Skew
  /// </summary>
  public static String? GetSkewAmount(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.SkewAmount?.Value;
  }
  
  public static void SetSkewAmount(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SkewAmount = new StringValue { Value = value };
      else
        openXmlElement.SkewAmount = null;
  }
  
  /// <summary>
  /// Forward Extrusion
  /// </summary>
  public static String? GetForceDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.ForceDepth?.Value;
  }
  
  public static void SetForceDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForceDepth = new StringValue { Value = value };
      else
        openXmlElement.ForceDepth = null;
  }
  
  /// <summary>
  /// Backward Extrusion Depth
  /// </summary>
  public static String? GetBackDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.BackDepth?.Value;
  }
  
  public static void SetBackDepth(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BackDepth = new StringValue { Value = value };
      else
        openXmlElement.BackDepth = null;
  }
  
  /// <summary>
  /// Rotation Axis
  /// </summary>
  public static String? GetOrientation(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Orientation?.Value;
  }
  
  public static void SetOrientation(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Orientation = new StringValue { Value = value };
      else
        openXmlElement.Orientation = null;
  }
  
  /// <summary>
  /// Rotation Around Axis
  /// </summary>
  public static Single? GetOrientationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.OrientationAngle?.Value;
  }
  
  public static void SetOrientationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.OrientationAngle = value;
  }
  
  /// <summary>
  /// Rotation Toggle
  /// </summary>
  public static Boolean? GetLockRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetLockRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Center of Rotation Toggle
  /// </summary>
  public static Boolean? GetAutoRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAutoRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Rotation Center
  /// </summary>
  public static String? GetRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.RotationCenter?.Value;
  }
  
  public static void SetRotationCenter(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotationCenter = new StringValue { Value = value };
      else
        openXmlElement.RotationCenter = null;
  }
  
  /// <summary>
  /// X-Y Rotation Angle
  /// </summary>
  public static String? GetRotationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.RotationAngle?.Value;
  }
  
  public static void SetRotationAngle(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotationAngle = new StringValue { Value = value };
      else
        openXmlElement.RotationAngle = null;
  }
  
  /// <summary>
  /// Extrusion Color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Shininess
  /// </summary>
  public static Single? GetShininess(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Shininess?.Value;
  }
  
  public static void SetShininess(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.Shininess = value;
  }
  
  /// <summary>
  /// Specularity
  /// </summary>
  public static String? GetSpecularity(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Specularity?.Value;
  }
  
  public static void SetSpecularity(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Specularity = new StringValue { Value = value };
      else
        openXmlElement.Specularity = null;
  }
  
  /// <summary>
  /// Diffuse Reflection
  /// </summary>
  public static String? GetDiffusity(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Diffusity?.Value;
  }
  
  public static void SetDiffusity(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Diffusity = new StringValue { Value = value };
      else
        openXmlElement.Diffusity = null;
  }
  
  /// <summary>
  /// Metallic Surface Toggle
  /// </summary>
  public static Boolean? GetMetal(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetMetal(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Simulated Bevel
  /// </summary>
  public static String? GetEdge(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Edge?.Value;
  }
  
  public static void SetEdge(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Edge = new StringValue { Value = value };
      else
        openXmlElement.Edge = null;
  }
  
  /// <summary>
  /// Faceting Quality
  /// </summary>
  public static String? GetFacet(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Facet?.Value;
  }
  
  public static void SetFacet(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Facet = new StringValue { Value = value };
      else
        openXmlElement.Facet = null;
  }
  
  /// <summary>
  /// Shape Face Lighting Toggle
  /// </summary>
  public static Boolean? GetLightFace(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetLightFace(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  public static String? GetBrightness(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.Brightness?.Value;
  }
  
  public static void SetBrightness(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Brightness = new StringValue { Value = value };
      else
        openXmlElement.Brightness = null;
  }
  
  /// <summary>
  /// Primary Light Position
  /// </summary>
  public static String? GetLightPosition(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.LightPosition?.Value;
  }
  
  public static void SetLightPosition(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightPosition = new StringValue { Value = value };
      else
        openXmlElement.LightPosition = null;
  }
  
  /// <summary>
  /// Primary Light Intensity
  /// </summary>
  public static String? GetLightLevel(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.LightLevel?.Value;
  }
  
  public static void SetLightLevel(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightLevel = new StringValue { Value = value };
      else
        openXmlElement.LightLevel = null;
  }
  
  /// <summary>
  /// Primary Light Harshness Toggle
  /// </summary>
  public static Boolean? GetLightHarsh(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetLightHarsh(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Secondary Light Position
  /// </summary>
  public static String? GetLightPosition2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.LightPosition2?.Value;
  }
  
  public static void SetLightPosition2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightPosition2 = new StringValue { Value = value };
      else
        openXmlElement.LightPosition2 = null;
  }
  
  /// <summary>
  /// Secondary Light Intensity
  /// </summary>
  public static String? GetLightLevel2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    return openXmlElement?.LightLevel2?.Value;
  }
  
  public static void SetLightLevel2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LightLevel2 = new StringValue { Value = value };
      else
        openXmlElement.LightLevel2 = null;
  }
  
  /// <summary>
  /// Secondary Light Harshness Toggle
  /// </summary>
  public static Boolean? GetLightHarsh2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetLightHarsh2(DocumentFormat.OpenXml.Vml.Office.Extrusion? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
