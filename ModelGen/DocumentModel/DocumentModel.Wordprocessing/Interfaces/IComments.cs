namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public interface IComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the WordprocessingCommentsPart associated with this element.
  /// </summary>
  public IWordprocessingCommentsPart? WordprocessingCommentsPart { get ; set; }
  
}
