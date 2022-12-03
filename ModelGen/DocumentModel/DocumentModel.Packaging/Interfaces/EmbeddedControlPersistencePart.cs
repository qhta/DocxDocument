namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control")]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart), false, true)]
public interface EmbeddedControlPersistencePart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
