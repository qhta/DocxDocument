namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public interface HeaderFooterReferenceType
{
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Wordprocessing.HeaderFooterKind? Type { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id { get ; set; }
  
}
