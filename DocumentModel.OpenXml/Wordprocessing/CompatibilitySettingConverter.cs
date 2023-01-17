namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public static class CompatibilitySettingConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static DocumentModel.Wordprocessing.CompatSettingNameKind? GetName(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DocumentModel.Wordprocessing.CompatSettingNameKind>(openXmlElement?.Name?.Value);
  }
  
  private static void SetName(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting openXmlElement, DocumentModel.Wordprocessing.CompatSettingNameKind? value)
  {
    openXmlElement.Name = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DocumentModel.Wordprocessing.CompatSettingNameKind>(value);
  }
  
  /// <summary>
  /// uri
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DocumentModel.Wordprocessing.CompatibilitySetting? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CompatibilitySetting();
      value.Name = GetName(openXmlElement);
      value.Uri = GetUri(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CompatibilitySetting? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetUri(openXmlElement, value?.Uri);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
