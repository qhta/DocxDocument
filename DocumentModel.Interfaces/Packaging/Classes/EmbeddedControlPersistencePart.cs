namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedControlPersistencePart
/// </summary>
public interface EmbeddedControlPersistencePart: IModelElement
{
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }
  public string? RelationshipType { get; set; }
}