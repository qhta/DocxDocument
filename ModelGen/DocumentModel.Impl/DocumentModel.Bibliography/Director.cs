namespace DocumentModel.Bibliography;

/// <summary>
/// Director.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public class Director: IDirector
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
