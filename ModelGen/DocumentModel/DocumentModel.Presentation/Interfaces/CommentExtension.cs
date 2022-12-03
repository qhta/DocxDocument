namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentExtension Class.
/// </summary>
public interface CommentExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ThreadingInfo? ThreadingInfo { get ; set; }
  
}
