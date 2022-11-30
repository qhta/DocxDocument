namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentExtension Class.
/// </summary>
public interface ICommentExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.PowerPoint.IThreadingInfo? ThreadingInfo { get ; set; }
  
}
