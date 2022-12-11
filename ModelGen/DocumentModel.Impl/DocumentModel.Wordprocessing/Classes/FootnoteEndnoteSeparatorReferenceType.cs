namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public class FootnoteEndnoteSeparatorReferenceTypeImpl: ModelElementImpl, FootnoteEndnoteSeparatorReferenceType
{
  public DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FootnoteEndnoteSeparatorReferenceTypeImpl(): base() {}
  
  public FootnoteEndnoteSeparatorReferenceTypeImpl(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public Int32? Id
  {
    get => (Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
}
