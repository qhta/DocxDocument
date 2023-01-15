using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public static class FootnoteEndnoteSeparatorReferenceTypeConverter
{
  /// <summary>
  ///   Footnote/Endnote ID
  /// </summary>
  public static Int64? GetId(FootnoteEndnoteSeparatorReferenceType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(FootnoteEndnoteSeparatorReferenceType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  public static DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? CreateModelElement(FootnoteEndnoteSeparatorReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? value)
    where OpenXmlElementType : FootnoteEndnoteSeparatorReferenceType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}