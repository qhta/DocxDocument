namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ThreadingInfo Class.
/// </summary>
public interface IThreadingInfo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// timeZoneBias, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Int32? TimeZoneBias { get ; set; }
  
  /// <summary>
  /// ParentCommentIdentifier.
  /// </summary>
  public DocumentModel.Office2013.PowerPoint.IParentCommentIdentifier? ParentCommentIdentifier { get ; set; }
  
}
