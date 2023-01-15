using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using HelpText = DocumentFormat.OpenXml.Wordprocessing.HelpText;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Associated Help Text.
/// </summary>
public static class HelpTextConverter
{
  /// <summary>
  ///   Help Text Type
  /// </summary>
  public static InfoTextKind? GetType(HelpText? openXmlElement)
  {
    return EnumValueConverter.GetValue<InfoTextValues, InfoTextKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(HelpText? openXmlElement, InfoTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<InfoTextValues, InfoTextKind>(value);
  }

  /// <summary>
  ///   Help Text Value
  /// </summary>
  public static String? GetVal(HelpText? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(HelpText? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Wordprocessing.HelpText? CreateModelElement(HelpText? openXmlElement)
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
    where OpenXmlElementType : HelpText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}