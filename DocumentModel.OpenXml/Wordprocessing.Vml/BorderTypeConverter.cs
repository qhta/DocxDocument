namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public static class BorderTypeConverter
{
  /// <summary>
  /// Border Style
  /// </summary>
  public static DocumentModel.Wordprocessing.Vml.BorderKind? GetType(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DocumentModel.Wordprocessing.Vml.BorderKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement, DocumentModel.Wordprocessing.Vml.BorderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DocumentModel.Wordprocessing.Vml.BorderKind>(value);
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public static Int64? GetWidth(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public static Boolean? GetShadow(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetShadow(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static DocumentModel.Wordprocessing.Vml.BorderType? CreateModelElement(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Vml.BorderType();
      value.Type = GetType(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Vml.BorderType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
