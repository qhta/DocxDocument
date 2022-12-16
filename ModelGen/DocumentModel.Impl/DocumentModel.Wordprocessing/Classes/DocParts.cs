namespace DocumentModel.Wordprocessing;

/// <summary>
/// List of Glossary Document Entries.
/// </summary>
public class DocPartsImpl: ModelElementImpl, DocParts
{
  public DocumentFormat.OpenXml.Wordprocessing.DocParts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocParts?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocPartsImpl(): base() {}
  
  public DocPartsImpl(DocumentFormat.OpenXml.Wordprocessing.DocParts openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
}
