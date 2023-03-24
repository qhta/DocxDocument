namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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