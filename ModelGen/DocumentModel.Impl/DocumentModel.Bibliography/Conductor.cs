namespace DocumentModel.Bibliography;

/// <summary>
/// Conductor.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public class Conductor: IConductor
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
