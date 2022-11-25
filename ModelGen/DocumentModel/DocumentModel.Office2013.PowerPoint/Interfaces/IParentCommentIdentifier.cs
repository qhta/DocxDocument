namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ParentCommentIdentifier Class.
/// </summary>
public interface IParentCommentIdentifier // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// authorId, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? AuthorId { get ; set; }
  
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
}
