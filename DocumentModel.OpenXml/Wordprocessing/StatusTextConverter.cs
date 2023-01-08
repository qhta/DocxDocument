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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.StatusText? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
