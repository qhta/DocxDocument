namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public static class FootnoteEndnoteSeparatorReferenceTypeConverter
{
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  private static Int64? GetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType openXmlElement, Int64? value)
  {
    openXmlElement.Id = value;
  }
  
  public static DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType, new()
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
