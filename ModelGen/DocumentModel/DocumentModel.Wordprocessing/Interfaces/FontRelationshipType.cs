namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontRelationshipType Class.
/// </summary>
public interface FontRelationshipType // : System.Boolean
{
  /// <summary>
  /// fontKey
  /// </summary>
  public String? FontKey { get ; set; }
  
  /// <summary>
  /// subsetted
  /// </summary>
  public Boolean? Subsetted { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id { get ; set; }
  
}
