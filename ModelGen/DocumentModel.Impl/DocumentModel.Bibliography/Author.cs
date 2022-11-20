namespace DocumentModel.Bibliography;

/// <summary>
/// Author.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICorporate))]
public class Author: IAuthor
{
  /// <summary>
  /// NameList.
  /// </summary>
  public INameList? NameList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Corporate Author.
  /// </summary>
  public ICorporate? Corporate
  {
    get;
    set;
  }
  
}
