namespace DocumentModel.Bibliography;

/// <summary>
/// Performer.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICorporate))]
public class Performer: IPerformer
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
