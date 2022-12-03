namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ThreadingInfo Class.
/// </summary>
public interface ThreadingInfo // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// timeZoneBias, this property is only available in Office 2013 and later.
  /// </summary>
  public Int32? TimeZoneBias { get ; set; }
  
  /// <summary>
  /// ParentCommentIdentifier.
  /// </summary>
  public ParentCommentIdentifier? ParentCommentIdentifier { get ; set; }
  
}
