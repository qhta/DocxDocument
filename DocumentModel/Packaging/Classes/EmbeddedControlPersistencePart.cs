namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedControlPersistencePart
/// </summary>
public record EmbeddedControlPersistencePart
{
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }

  public String? RelationshipType { get; set; }
}