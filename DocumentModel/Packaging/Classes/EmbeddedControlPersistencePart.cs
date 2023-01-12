namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public partial class EmbeddedControlPersistencePart
{
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
