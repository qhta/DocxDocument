namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedControlPersistencePart
/// </summary>
public interface EmbeddedControlPersistencePart: OpenXmlPart
{
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataParts EmbeddedControlPersistenceBinaryDataParts { get; set; }
  public string? RelationshipType { get; set; }
}