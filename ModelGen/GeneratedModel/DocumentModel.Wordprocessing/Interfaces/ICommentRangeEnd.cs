namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentRangeEnd Class.
/// </summary>
public interface ICommentRangeEnd // : DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType
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
