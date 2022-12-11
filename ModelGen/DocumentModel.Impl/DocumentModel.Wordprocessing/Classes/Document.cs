namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
public class DocumentImpl: ModelElementImpl, Document
{
  public DocumentFormat.OpenXml.Wordprocessing.Document? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Document?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocumentImpl(): base() {}
  
  public DocumentImpl(DocumentFormat.OpenXml.Wordprocessing.Document openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// conformance
  /// </summary>
  public DocumentConformance? Conformance
  {
    get => (DocumentConformance?)OpenXmlElement?.Conformance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Conformance = (DocumentFormat.OpenXml.Wordprocessing.DocumentConformance?)value;
    }
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
  /// Body.
  /// </summary>
  public Body? Body
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
