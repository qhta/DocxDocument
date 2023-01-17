namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public static class BorderTypeConverter
{
  /// <summary>
  /// Border Style
  /// </summary>
  private static DocumentModel.Wordprocessing.Vml.BorderKind? GetType(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DocumentModel.Wordprocessing.Vml.BorderKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType openXmlElement, DocumentModel.Wordprocessing.Vml.BorderKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DocumentModel.Wordprocessing.Vml.BorderKind>(value);
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  private static Int64? GetWidth(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  private static Boolean? GetShadow(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement?.Shadow?.Value;
  }
  
  private static void SetShadow(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Shadow = value;
    else
      openXmlElement.Shadow = null;
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetWidth(openXmlElement, value?.Width);
      SetShadow(openXmlElement, value?.Shadow);
      return openXmlElement;
    }
    return default;
  }
}
