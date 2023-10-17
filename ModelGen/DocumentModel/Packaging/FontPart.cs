namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains a given font embedded directly into the document. (This is useful when using custom fonts or fonts that are not widely distributed.)
/// </summary>
public partial class FontPart
{
  public String? RelationshipType { get; set; }
  
}
