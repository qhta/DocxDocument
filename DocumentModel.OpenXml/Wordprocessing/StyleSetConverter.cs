using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using StyleSet = DocumentFormat.OpenXml.Office2010.Word.StyleSet;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the StyleSet Class.
/// </summary>
public static class StyleSetConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static UInt32? GetId(StyleSet? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(StyleSet? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  public static OnOffKind? GetVal(StyleSet? openXmlElement)
  {
    return EnumValueConverter.GetValue<OnOffValues, OnOffKind>(openXmlElement?.Val?.Value);
  }

  public static void SetVal(StyleSet? openXmlElement, OnOffKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<OnOffValues, OnOffKind>(value);
  }

  public static DocumentModel.Wordprocessing.StyleSet? CreateModelElement(StyleSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StyleSet();
      value.Id = GetId(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StyleSet? value)
    where OpenXmlElementType : StyleSet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}