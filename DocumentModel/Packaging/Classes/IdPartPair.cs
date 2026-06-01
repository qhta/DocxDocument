namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public class IdPartPair: ModelElement
{
  /// <summary>
  ///   Gets or sets the relationship ID Iin the pair.
  /// </summary>
  public string? RelationshipId { get; set; }
}
