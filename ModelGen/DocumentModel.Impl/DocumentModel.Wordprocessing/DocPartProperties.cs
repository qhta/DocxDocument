namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBehaviors))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICategory))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartName))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartTypes))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDescription))]
public class DocPartProperties: IDocPartProperties
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  public IDocPartName? DocPartName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  public IStyleId? StyleId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  public DocumentModel.Wordprocessing.ICategory? Category
  {
    get;
    set;
  }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public IDocPartTypes? DocPartTypes
  {
    get;
    set;
  }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public IBehaviors? Behaviors
  {
    get;
    set;
  }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  public DocumentModel.Wordprocessing.IDescription? Description
  {
    get;
    set;
  }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  public IDocPartId? DocPartId
  {
    get;
    set;
  }
  
}
