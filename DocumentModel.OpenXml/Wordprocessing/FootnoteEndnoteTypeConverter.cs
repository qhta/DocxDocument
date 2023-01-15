using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FootnoteEndnoteType = DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FootnoteEndnoteType Class.
/// </summary>
public static class FootnoteEndnoteTypeConverter
{
  /// <summary>
  ///   Footnote/Endnote Type
  /// </summary>
  public static FootnoteEndnoteKind? GetType(FootnoteEndnoteType? openXmlElement)
  {
    return EnumValueConverter.GetValue<FootnoteEndnoteValues, FootnoteEndnoteKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(FootnoteEndnoteType? openXmlElement, FootnoteEndnoteKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<FootnoteEndnoteValues, FootnoteEndnoteKind>(value);
  }

  /// <summary>
  ///   Footnote/Endnote ID
  /// </summary>
  public static Int64? GetId(FootnoteEndnoteType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(FootnoteEndnoteType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  public static DocumentModel.Wordprocessing.FootnoteEndnoteType? CreateModelElement(FootnoteEndnoteType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FootnoteEndnoteType();
      value.Type = GetType(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FootnoteEndnoteType? value)
    where OpenXmlElementType : FootnoteEndnoteType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}