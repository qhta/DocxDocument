namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public class FootnoteEndnoteReferenceTypeImpl: ModelElementImpl, FootnoteEndnoteReferenceType
{
  public DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FootnoteEndnoteReferenceTypeImpl(): base() {}
  
  public FootnoteEndnoteReferenceTypeImpl(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  public Boolean? CustomMarkFollows
  {
    get => (System.Boolean?)OpenXmlElement?.CustomMarkFollows?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CustomMarkFollows = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  public Int32? Id
  {
    get => (System.Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
}
