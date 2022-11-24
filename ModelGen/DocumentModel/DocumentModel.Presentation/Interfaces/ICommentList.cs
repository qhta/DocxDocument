namespace DocumentModel.Presentation;

/// <summary>
/// Comment List.
/// </summary>
public interface ICommentList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the SlideCommentsPart associated with this element.
  /// </summary>
  public SlideCommentsPart? SlideCommentsPart { get ; set; }
  
}
