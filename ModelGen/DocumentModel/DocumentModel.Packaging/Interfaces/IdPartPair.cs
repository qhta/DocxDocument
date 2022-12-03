namespace DocumentModel.Packaging;

/// <summary>
/// Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public interface IdPartPair // : 
{
  /// <summary>
  /// Gets or sets the relationship ID in the pair.
  /// </summary>
  public String? RelationshipId { get ; set; }
  
}
