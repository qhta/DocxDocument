namespace DocumentModel.Bibliography;

/// <summary>
/// Interviewer.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public class Interviewer: IInterviewer
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
