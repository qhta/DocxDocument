namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public partial class FootnotesImpl: ModelElementImpl, Footnotes
{
  public DocumentFormat.OpenXml.Wordprocessing.Footnotes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Footnotes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FootnotesImpl(): base() {}
  
  public FootnotesImpl(DocumentFormat.OpenXml.Wordprocessing.Footnotes openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the FootnotesPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.FootnotesPart? FootnotesPart
  {
    get
    {
      if (OpenXmlElement?.FootnotesPart != null)
        return new DocumentModel.Packaging.FootnotesPartImpl(OpenXmlElement.FootnotesPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.FootnotesPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
  public DocumentModel.Wordprocessing.Footnote? Footnote
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Footnote>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FootnoteImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Footnote>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FootnoteImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
