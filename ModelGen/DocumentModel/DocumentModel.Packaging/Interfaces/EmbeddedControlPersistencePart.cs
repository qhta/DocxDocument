namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public interface EmbeddedControlPersistencePart
{
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
