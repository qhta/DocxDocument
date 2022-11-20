namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comment Content Reference Mark.
/// </summary>
public interface ICommentReference // : DocumentFormat.OpenXml.Wordprocessing.MarkupType
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
