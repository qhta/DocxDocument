namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Skew Transform.
/// </summary>
public static class SkewConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Skew ID
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Skew Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Skew Offset
  /// </summary>
  public static String? GetOffset(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement)
  {
    return openXmlElement?.Offset?.Value;
  }
  
  public static void SetOffset(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Offset = new StringValue { Value = value };
      else
        openXmlElement.Offset = null;
  }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  public static String? GetOrigin(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }
  
  public static void SetOrigin(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Origin = new StringValue { Value = value };
      else
        openXmlElement.Origin = null;
  }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  public static String? GetMatrix(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement)
  {
    return openXmlElement?.Matrix?.Value;
  }
  
  public static void SetMatrix(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Matrix = new StringValue { Value = value };
      else
        openXmlElement.Matrix = null;
  }
  
  public static DocumentModel.Vml.Skew? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Skew? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Skew();
      value.Extension = GetExtension(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Origin = GetOrigin(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Skew? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Skew, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetId(openXmlElement, value?.Id);
      SetOn(openXmlElement, value?.On);
      SetOffset(openXmlElement, value?.Offset);
      SetOrigin(openXmlElement, value?.Origin);
      SetMatrix(openXmlElement, value?.Matrix);
      return openXmlElement;
    }
    return default;
  }
}
