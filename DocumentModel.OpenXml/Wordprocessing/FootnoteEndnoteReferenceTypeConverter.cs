namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public static class FootnoteEndnoteReferenceTypeConverter
{
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  private static Boolean? GetCustomMarkFollows(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType openXmlElement)
  {
    return openXmlElement?.CustomMarkFollows?.Value;
  }
  
  private static void SetCustomMarkFollows(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CustomMarkFollows = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CustomMarkFollows = null;
  }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  private static Int64? GetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType openXmlElement, Int64? value)
  {
    openXmlElement.Id = value;
  }
  
  public static DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType, new()
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
