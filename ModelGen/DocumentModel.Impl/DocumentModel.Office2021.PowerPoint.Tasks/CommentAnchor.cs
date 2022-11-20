namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the CommentAnchor Class.
/// </summary>
public class CommentAnchor: ICommentAnchor
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
