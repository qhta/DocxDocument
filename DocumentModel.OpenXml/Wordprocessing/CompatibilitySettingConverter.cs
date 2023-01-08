namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public static class CompatibilitySettingConverter
{
  /// <summary>
  /// name
  /// </summary>
  public static DocumentModel.Wordprocessing.CompatSettingNameKind? GetName(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DocumentModel.Wordprocessing.CompatSettingNameKind>(openXmlElement?.Name?.Value);
  }
  
  public static void SetName(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting? openXmlElement, DocumentModel.Wordprocessing.CompatSettingNameKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Name = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DocumentModel.Wordprocessing.CompatSettingNameKind>(value);
  }
  
  /// <summary>
  /// uri
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// val
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
