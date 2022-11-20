namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

/// <summary>
/// Defines the AtrbtnTaskAssignUnassignUser Class.
/// </summary>
public class AtrbtnTaskAssignUnassignUser: IAtrbtnTaskAssignUnassignUser
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
