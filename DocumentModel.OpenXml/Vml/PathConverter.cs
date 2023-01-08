namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Path Class.
/// </summary>
public static class PathConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public static String? GetValue(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetValue(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  public static String? GetLimo(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLimo(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  public static String? GetTextboxRectangle(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTextboxRectangle(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public static Boolean? GetAllowFill(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowFill(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public static Boolean? GetAllowStroke(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowStroke(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public static Boolean? GetAllowShading(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowShading(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Arrowhead Display Toggle
  /// </summary>
  public static Boolean? GetShowArrowhead(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowArrowhead(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Gradient Shape Toggle
  /// </summary>
  public static Boolean? GetAllowGradientShape(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowGradientShape(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public static Boolean? GetAllowTextPath(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowTextPath(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Inset Stroke From Path Flag
  /// </summary>
  public static Boolean? GetAllowInsetPen(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowInsetPen(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Connection Point Type
  /// </summary>
  public static DocumentModel.Vml.ConnectKind? GetConnectionPointType(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues, DocumentModel.Vml.ConnectKind>(openXmlElement?.ConnectionPointType?.Value);
  }
  
  public static void SetConnectionPointType(DocumentFormat.OpenXml.Vml.Path? openXmlElement, DocumentModel.Vml.ConnectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ConnectionPointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues, DocumentModel.Vml.ConnectKind>(value);
  }
  
  /// <summary>
  /// Connection Points
  /// </summary>
  public static String? GetConnectionPoints(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetConnectionPoints(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  public static String? GetConnectAngles(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetConnectAngles(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public static Boolean? GetAllowExtrusion(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowExtrusion(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
