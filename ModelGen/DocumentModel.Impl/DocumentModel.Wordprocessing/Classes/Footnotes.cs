namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public class FootnotesImpl: ModelElementImpl, Footnotes
{
  public DocumentFormat.OpenXml.Wordprocessing.Footnotes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Footnotes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Footnote>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
