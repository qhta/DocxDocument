namespace DocumentModel.Bibliography;

/// <summary>
/// Counsel.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public class Counsel: ICounsel
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
