namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Associated Status Text.
/// </summary>
public static class StatusTextConverter
{
  /// <summary>
  /// Status Text Type
  /// </summary>
  public static DocumentModel.Wordprocessing.InfoTextKind? GetType(DocumentFormat.OpenXml.Wordprocessing.StatusText? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DocumentModel.Wordprocessing.InfoTextKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.StatusText? openXmlElement, DocumentModel.Wordprocessing.InfoTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DocumentModel.Wordprocessing.InfoTextKind>(value);
  }
  
  /// <summary>
  /// Status Text Value
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.StatusText? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.StatusText? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  public static DocumentModel.Wordprocessing.StatusText? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.StatusText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StatusText();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StatusText? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.StatusText, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
