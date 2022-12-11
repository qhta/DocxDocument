namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public class GlossaryDocumentImpl: ModelElementImpl, GlossaryDocument
{
  public DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GlossaryDocumentImpl(): base() {}
  
  public GlossaryDocumentImpl(DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  public ModelElement? DocParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
