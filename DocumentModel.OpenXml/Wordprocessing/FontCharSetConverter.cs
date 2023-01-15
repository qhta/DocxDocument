using DocumentFormat.OpenXml.Wordprocessing;
using StrictCharacterSet = DocumentModel.Wordprocessing.StrictCharacterSet;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FontCharSet Class.
/// </summary>
public static class FontCharSetConverter
{
  /// <summary>
  ///   val
  /// </summary>
  public static String? GetVal(FontCharSet? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(FontCharSet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  /// <summary>
  ///   characterSet
  /// </summary>
  public static StrictCharacterSet? GetStrictCharacterSet(FontCharSet? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, StrictCharacterSet>(openXmlElement?.StrictCharacterSet?.Value);
  }

  public static void SetStrictCharacterSet(FontCharSet? openXmlElement, StrictCharacterSet? value)
  {
    if (openXmlElement != null)
      openXmlElement.StrictCharacterSet = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, StrictCharacterSet>(value);
  }

  public static DocumentModel.Wordprocessing.FontCharSet? CreateModelElement(FontCharSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FontCharSet();
      value.Val = GetVal(openXmlElement);
      value.StrictCharacterSet = GetStrictCharacterSet(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FontCharSet? value)
    where OpenXmlElementType : FontCharSet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetStrictCharacterSet(openXmlElement, value?.StrictCharacterSet);
      return openXmlElement;
    }
    return default;
  }
}