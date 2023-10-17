namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part contains information about an embedded control in the package. This information is provided by the specified control when asked to persist.
/// </summary>
public partial class EmbeddedControlPersistencePart
{
  
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
