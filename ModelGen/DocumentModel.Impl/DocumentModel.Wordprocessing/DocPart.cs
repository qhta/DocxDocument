namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartBody))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartProperties))]
public class DocPart: IDocPart
{
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  public IDocPartProperties? DocPartProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  public IDocPartBody? DocPartBody
  {
    get;
    set;
  }
  
}
