namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part contains properties specific to an Office Open XML document.
/// </summary>
public partial class ExtendedFilePropertiesPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMP.ExtendedProperties? Properties { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
