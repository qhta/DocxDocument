namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
public class DocPartImpl: ModelElementImpl, DocPart
{
  public DocumentFormat.OpenXml.Wordprocessing.DocPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocPartImpl(): base() {}
  
  public DocPartImpl(DocumentFormat.OpenXml.Wordprocessing.DocPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  public DocPartProperties? DocPartProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  public DocPartBody? DocPartBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
