namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocumentBackground))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBody))]
public class Document: IDocument
{
  /// <summary>
  /// conformance
  /// </summary>
  public DocumentConformance? Conformance
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public IDocumentBackground? DocumentBackground
  {
    get;
    set;
  }
  
  /// <summary>
  /// Body.
  /// </summary>
  public IBody? Body
  {
    get;
    set;
  }
  
}
