namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocumentBackground))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocParts))]
public class GlossaryDocument: IGlossaryDocument
{
  /// <summary>
  /// Document Background.
  /// </summary>
  public IDocumentBackground? DocumentBackground
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  public IDocParts? DocParts
  {
    get;
    set;
  }
  
}
