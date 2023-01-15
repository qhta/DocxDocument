using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using CompatibilitySetting = DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the CompatibilitySetting Class.
/// </summary>
public static class CompatibilitySettingConverter
{
  /// <summary>
  ///   name
  /// </summary>
  public static CompatSettingNameKind? GetName(CompatibilitySetting? openXmlElement)
  {
    return EnumValueConverter.GetValue<CompatSettingNameValues, CompatSettingNameKind>(openXmlElement?.Name?.Value);
  }

  public static void SetName(CompatibilitySetting? openXmlElement, CompatSettingNameKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Name = EnumValueConverter.CreateEnumValue<CompatSettingNameValues, CompatSettingNameKind>(value);
  }

  /// <summary>
  ///   uri
  /// </summary>
  public static String? GetUri(CompatibilitySetting? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(CompatibilitySetting? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  /// <summary>
  ///   val
  /// </summary>
  public static String? GetVal(CompatibilitySetting? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(CompatibilitySetting? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Wordprocessing.CompatibilitySetting? CreateModelElement(CompatibilitySetting? openXmlElement)
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
    where OpenXmlElementType : CompatibilitySetting, new()
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