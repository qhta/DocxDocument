namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public interface HeaderFooterReferenceType // : System.Boolean
{
  /// <summary>
  /// type
  /// </summary>
  public HeaderFooterKind? Type { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id { get ; set; }
  
}
