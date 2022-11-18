namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the AtrbtnTaskAssignUnassignUser Class.
/// </summary>
public interface IAtrbtnTaskAssignUnassignUser // : DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.OpenXmlTaskAssignUnassignUserElement
{
  /// <summary>
  /// authorId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? AuthorId { get ; set; }
  
}
