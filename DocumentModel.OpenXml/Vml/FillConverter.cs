namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public static class FillConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public static DocumentModel.Vml.FillKind? GetType(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, DocumentModel.Vml.FillKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(value);
  }
  
  /// <summary>
  /// Fill Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Primary Color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  public static String? GetOpacity(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOpacity(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  public static String? GetColor2(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetColor2(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  public static String? GetSource(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSource(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public static String? GetHref(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetHref(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  public static String? GetAlternateImageReference(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAlternateImageReference(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  public static String? GetSize(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSize(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  public static String? GetOrigin(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOrigin(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  public static String? GetPosition(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  public static DocumentModel.Vml.ImageAspectKind? GetAspect(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(openXmlElement?.Aspect?.Value);
  }
  
  public static void SetAspect(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, DocumentModel.Vml.ImageAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Aspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Intermediate Colors
  /// </summary>
  public static String? GetColors(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetColors(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Gradient Angle
  /// </summary>
  public static Decimal? GetAngle(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAngle(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Decimal? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Align Image With Shape
  /// </summary>
  public static Boolean? GetAlignShape(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlignShape(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Gradient Center
  /// </summary>
  public static String? GetFocus(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFocus(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  public static String? GetFocusSize(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFocusSize(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  public static String? GetFocusPosition(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFocusPosition(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  public static DocumentModel.Vml.FillMethodKind? GetMethod(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DocumentModel.Vml.FillMethodKind>(openXmlElement?.Method?.Value);
  }
  
  public static void SetMethod(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, DocumentModel.Vml.FillMethodKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DocumentModel.Vml.FillMethodKind>(value);
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  public static Boolean? GetDetectMouseClick(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDetectMouseClick(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  public static String? GetOpacity2(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOpacity2(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Recolor Fill as Picture
  /// </summary>
  public static Boolean? GetRecolor(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRecolor(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rotate Fill with Shape
  /// </summary>
  public static Boolean? GetRotate(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRotate(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public static String? GetRelationshipId(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetRelationshipId(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  public static DocumentModel.Vml.FillExtendedProperties? GetFillExtendedProperties(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFillExtendedProperties(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, DocumentModel.Vml.FillExtendedProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
