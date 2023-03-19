namespace DocumentModel.Packaging;

/// <summary>
///   Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public class IdPartPair: ModelElement
{
  /// <summary>
  ///   Gets or sets the relationship ID in the pair.
  /// </summary>
  public String? RelationshipId { get; set; }
}