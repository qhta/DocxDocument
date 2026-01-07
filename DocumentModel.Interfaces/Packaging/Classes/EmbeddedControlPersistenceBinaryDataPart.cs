namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public interface EmbeddedControlPersistenceBinaryDataPart: OpenXmlPart
{
  public string? RelationshipType { get; set; }
}