namespace DocumentModel.Bibliography;

/// <summary>
/// Book Author.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public class BookAuthor: IBookAuthor
{
  /// <summary>
  /// Name List.
  /// </summary>
  public INameList? NameList
  {
    get;
    set;
  }
  
}
