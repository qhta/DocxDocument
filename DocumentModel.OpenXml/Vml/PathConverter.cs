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
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public static String? GetValue(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Value = new StringValue { Value = value };
      else
        openXmlElement.Value = null;
  }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  public static String? GetLimo(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    return openXmlElement?.Limo?.Value;
  }
  
  public static void SetLimo(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Limo = new StringValue { Value = value };
      else
        openXmlElement.Limo = null;
  }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  public static String? GetTextboxRectangle(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    return openXmlElement?.TextboxRectangle?.Value;
  }
  
  public static void SetTextboxRectangle(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextboxRectangle = new StringValue { Value = value };
      else
        openXmlElement.TextboxRectangle = null;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public static Boolean? GetAllowFill(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowFill(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public static Boolean? GetAllowStroke(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowStroke(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public static Boolean? GetAllowShading(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowShading(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Arrowhead Display Toggle
  /// </summary>
  public static Boolean? GetShowArrowhead(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetShowArrowhead(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Gradient Shape Toggle
  /// </summary>
  public static Boolean? GetAllowGradientShape(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowGradientShape(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public static Boolean? GetAllowTextPath(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowTextPath(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Inset Stroke From Path Flag
  /// </summary>
  public static Boolean? GetAllowInsetPen(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowInsetPen(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
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
    return openXmlElement?.ConnectionPoints?.Value;
  }
  
  public static void SetConnectionPoints(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ConnectionPoints = new StringValue { Value = value };
      else
        openXmlElement.ConnectionPoints = null;
  }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  public static String? GetConnectAngles(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    return openXmlElement?.ConnectAngles?.Value;
  }
  
  public static void SetConnectAngles(DocumentFormat.OpenXml.Vml.Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ConnectAngles = new StringValue { Value = value };
      else
        openXmlElement.ConnectAngles = null;
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public static Boolean? GetAllowExtrusion(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowExtrusion(DocumentFormat.OpenXml.Vml.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static DocumentModel.Vml.Path? CreateModelElement(DocumentFormat.OpenXml.Vml.Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Path();
      value.Id = GetId(openXmlElement);
      value.Value = GetValue(openXmlElement);
      value.Limo = GetLimo(openXmlElement);
      value.TextboxRectangle = GetTextboxRectangle(openXmlElement);
      value.AllowFill = GetAllowFill(openXmlElement);
      value.AllowStroke = GetAllowStroke(openXmlElement);
      value.AllowShading = GetAllowShading(openXmlElement);
      value.ShowArrowhead = GetShowArrowhead(openXmlElement);
      value.AllowGradientShape = GetAllowGradientShape(openXmlElement);
      value.AllowTextPath = GetAllowTextPath(openXmlElement);
      value.AllowInsetPen = GetAllowInsetPen(openXmlElement);
      value.ConnectionPointType = GetConnectionPointType(openXmlElement);
      value.ConnectionPoints = GetConnectionPoints(openXmlElement);
      value.ConnectAngles = GetConnectAngles(openXmlElement);
      value.AllowExtrusion = GetAllowExtrusion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Path? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Path, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetValue(openXmlElement, value?.Value);
      SetLimo(openXmlElement, value?.Limo);
      SetTextboxRectangle(openXmlElement, value?.TextboxRectangle);
      SetAllowFill(openXmlElement, value?.AllowFill);
      SetAllowStroke(openXmlElement, value?.AllowStroke);
      SetAllowShading(openXmlElement, value?.AllowShading);
      SetShowArrowhead(openXmlElement, value?.ShowArrowhead);
      SetAllowGradientShape(openXmlElement, value?.AllowGradientShape);
      SetAllowTextPath(openXmlElement, value?.AllowTextPath);
      SetAllowInsetPen(openXmlElement, value?.AllowInsetPen);
      SetConnectionPointType(openXmlElement, value?.ConnectionPointType);
      SetConnectionPoints(openXmlElement, value?.ConnectionPoints);
      SetConnectAngles(openXmlElement, value?.ConnectAngles);
      SetAllowExtrusion(openXmlElement, value?.AllowExtrusion);
      return openXmlElement;
    }
    return default;
  }
}
