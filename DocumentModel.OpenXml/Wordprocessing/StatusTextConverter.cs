using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using StatusText = DocumentFormat.OpenXml.Wordprocessing.StatusText;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Associated Status Text.
/// </summary>
public static class StatusTextConverter
{
  /// <summary>
  ///   Status Text Type
  /// </summary>
  public static InfoTextKind? GetType(StatusText? openXmlElement)
  {
    return EnumValueConverter.GetValue<InfoTextValues, InfoTextKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(StatusText? openXmlElement, InfoTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<InfoTextValues, InfoTextKind>(value);
  }

  /// <summary>
  ///   Status Text Value
  /// </summary>
  public static String? GetVal(StatusText? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(StatusText? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Wordprocessing.StatusText? CreateModelElement(StatusText? openXmlElement)
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
    where OpenXmlElementType : StatusText, new()
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