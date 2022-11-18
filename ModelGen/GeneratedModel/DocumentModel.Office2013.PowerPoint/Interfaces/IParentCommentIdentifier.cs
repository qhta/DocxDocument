namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ParentCommentIdentifier Class.
/// </summary>
public interface IParentCommentIdentifier // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// authorId, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? AuthorId { get ; set; }
  
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Index { get ; set; }
  
}
