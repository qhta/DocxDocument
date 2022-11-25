namespace DocumentModel.Packaging;

/// <summary>
/// Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public interface IIdPartPair // : 
{
  /// <summary>
  /// Gets or sets the relationship ID in the pair.
  /// </summary>
  public System.String? RelationshipId { get ; set; }
  
}
