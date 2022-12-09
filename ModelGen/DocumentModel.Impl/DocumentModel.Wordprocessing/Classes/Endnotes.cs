namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public class EndnotesImpl: ModelElementImpl, Endnotes
{
  public DocumentFormat.OpenXml.Wordprocessing.Endnotes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Endnotes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Endnote>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
