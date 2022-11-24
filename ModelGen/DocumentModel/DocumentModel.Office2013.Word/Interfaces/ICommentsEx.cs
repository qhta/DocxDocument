namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the CommentsEx Class.
/// </summary>
public interface ICommentsEx // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the WordprocessingCommentsExPart associated with this element.
  /// </summary>
  public WordprocessingCommentsExPart? WordprocessingCommentsExPart { get ; set; }
  
}
