namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public interface EmbeddedControlPersistenceBinaryDataPart: IModelElement
{
  public string? RelationshipType { get; set; }
}