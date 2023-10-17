namespace DocumentModel.Packaging;


/// <summary>
///   An image can be stored in a package as a ZIP item. Image ZIP items shall be identified by an image part relationship and the appropriate content type.
/// </summary>
public partial class ImagePart
{
  public String? RelationshipType { get; set; }
  
}
