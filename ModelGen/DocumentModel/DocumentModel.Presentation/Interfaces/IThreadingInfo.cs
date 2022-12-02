namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ThreadingInfo Class.
/// </summary>
public interface IThreadingInfo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// timeZoneBias, this property is only available in Office 2013 and later.
  /// </summary>
  public Int32? TimeZoneBias { get ; set; }
  
  /// <summary>
  /// ParentCommentIdentifier.
  /// </summary>
  public IParentCommentIdentifier? ParentCommentIdentifier { get ; set; }
  
}
