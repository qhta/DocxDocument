namespace DocumentModel.Bibliography;

/// <summary>
/// Interviewee.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public class Interviewee: IInterviewee
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
