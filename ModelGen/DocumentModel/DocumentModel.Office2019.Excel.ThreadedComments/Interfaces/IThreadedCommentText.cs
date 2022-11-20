namespace DocumentModel.Office2019.Excel.ThreadedComments;

/// <summary>
/// Defines the ThreadedCommentText Class.
/// </summary>
public interface IThreadedCommentText // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
