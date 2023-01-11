namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public static class FootnoteEndnoteSeparatorReferenceTypeConverter
{
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public static Int64? GetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
