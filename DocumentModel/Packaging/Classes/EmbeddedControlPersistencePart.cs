namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public partial class EmbeddedControlPersistencePart
{
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; }
  
  public String? RelationshipType { get; }
  
}
