namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part contains information about an embedded control in the package. This information is provided by the specified control when asked to persist.
/// </summary>
public partial class EmbeddedControlPersistencePart
{
  public String? RelationshipType { get; set; }
  
}
