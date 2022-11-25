namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the OpenXmlTaskAssignUnassignUserElement Class.
/// </summary>
public interface IOpenXmlTaskAssignUnassignUserElement // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// authorId, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? AuthorId { get ; set; }
  
}
