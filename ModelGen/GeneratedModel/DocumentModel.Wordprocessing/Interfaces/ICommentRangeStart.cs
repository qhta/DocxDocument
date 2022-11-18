namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentRangeStart Class.
/// </summary>
public interface ICommentRangeStart // : DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXml? DisplacedByCustomXml { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
