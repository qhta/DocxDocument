namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public static class CompatibilitySettingConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static DMW.CompatSettingNameKind? GetName(DXW.CompatibilitySetting openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DMW.CompatSettingNameKind>(openXmlElement?.Name?.Value);
  }
  
  private static void SetName(DXW.CompatibilitySetting openXmlElement, DMW.CompatSettingNameKind? value)
  {
    openXmlElement.Name = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DMW.CompatSettingNameKind>(value);
  }
  
  /// <summary>
  /// uri
  /// </summary>
  private static String? GetUri(DXW.CompatibilitySetting openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXW.CompatibilitySetting openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.CompatibilitySetting openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXW.CompatibilitySetting openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.CompatibilitySetting? CreateModelElement(DXW.CompatibilitySetting? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CompatibilitySetting();
      value.Name = GetName(openXmlElement);
      value.Uri = GetUri(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CompatibilitySetting? value)
    where OpenXmlElementType: DXW.CompatibilitySetting, new()
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
