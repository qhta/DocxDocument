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
  public static Int32? GetWidth(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public static Boolean? GetShadow(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShadow(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
