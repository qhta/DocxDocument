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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.HelpText? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
