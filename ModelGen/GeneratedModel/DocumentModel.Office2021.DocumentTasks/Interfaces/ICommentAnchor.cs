namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the CommentAnchor Class.
/// </summary>
public interface ICommentAnchor // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get ; set; }
  
}
