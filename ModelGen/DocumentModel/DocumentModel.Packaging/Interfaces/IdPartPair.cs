namespace DocumentModel.Packaging;

/// <summary>
/// Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public partial interface IdPartPair
{
  /// <summary>
  /// Gets or sets the relationship ID in the pair.
  /// </summary>
  public String? RelationshipId { get; set; }
  
  /// <summary>
  /// Gets or sets the OpenXmlPart in the pair.
  /// </summary>
  public DocumentModel.Packaging.OpenXmlPart? OpenXmlPart { get; set; }
  
}
