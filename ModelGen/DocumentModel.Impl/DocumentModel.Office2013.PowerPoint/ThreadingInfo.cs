namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ThreadingInfo Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.IParentCommentIdentifier))]
public class ThreadingInfo: IThreadingInfo
{
  /// <summary>
  /// timeZoneBias, this property is only available in Office 2013 and later.
  /// </summary>
  public int? TimeZoneBias
  {
    get;
    set;
  }
  
  /// <summary>
  /// ParentCommentIdentifier.
  /// </summary>
  public IParentCommentIdentifier? ParentCommentIdentifier
  {
    get;
    set;
  }
  
}
