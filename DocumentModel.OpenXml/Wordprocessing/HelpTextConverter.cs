namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public static class HelpTextConverter
{
  /// <summary>
  /// Help Text Type
  /// </summary>
  public static DocumentModel.Wordprocessing.InfoTextKind? GetType(DocumentFormat.OpenXml.Wordprocessing.HelpText? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DocumentModel.Wordprocessing.InfoTextKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.HelpText? openXmlElement, DocumentModel.Wordprocessing.InfoTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DocumentModel.Wordprocessing.InfoTextKind>(value);
  }
  
  /// <summary>
  /// Help Text Value
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.HelpText? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.HelpText? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  public static DocumentModel.Wordprocessing.HelpText? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.HelpText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.HelpText();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.HelpText? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.HelpText, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
