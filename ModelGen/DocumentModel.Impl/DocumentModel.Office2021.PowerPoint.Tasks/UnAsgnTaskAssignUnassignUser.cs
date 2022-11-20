namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the UnAsgnTaskAssignUnassignUser Class.
/// </summary>
public class UnAsgnTaskAssignUnassignUser: IUnAsgnTaskAssignUnassignUser
{
  /// <summary>
  /// authorId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? AuthorId
  {
    get;
    set;
  }
  
}
