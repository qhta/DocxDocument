using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public static class FootnoteEndnoteReferenceTypeConverter
{
  /// <summary>
  ///   Suppress Footnote/Endnote Reference Mark
  /// </summary>
  public static Boolean? GetCustomMarkFollows(FootnoteEndnoteReferenceType? openXmlElement)
  {
    return openXmlElement?.CustomMarkFollows?.Value;
  }

  public static void SetCustomMarkFollows(FootnoteEndnoteReferenceType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CustomMarkFollows = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.CustomMarkFollows = null;
  }

  /// <summary>
  ///   Footnote/Endnote ID Reference
  /// </summary>
  public static Int64? GetId(FootnoteEndnoteReferenceType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(FootnoteEndnoteReferenceType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  public static DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? CreateModelElement(FootnoteEndnoteReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType();
      value.CustomMarkFollows = GetCustomMarkFollows(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? value)
    where OpenXmlElementType : FootnoteEndnoteReferenceType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomMarkFollows(openXmlElement, value?.CustomMarkFollows);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}