namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BookmarkEnd Class.
/// </summary>
public interface IBookmarkEnd // : DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType
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
