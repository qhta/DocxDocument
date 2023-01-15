namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedControlPersistencePart
/// </summary>
public class EmbeddedControlPersistencePart
{
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }

  public String? RelationshipType { get; set; }
}