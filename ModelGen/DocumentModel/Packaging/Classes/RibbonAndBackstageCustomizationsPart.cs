namespace DocumentModel.Packaging;


/// <summary>
///   Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public partial class RibbonAndBackstageCustomizationsPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomUI? CustomUI { get; set; }
  
  
  /// <summary>
  ///   Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  public Collection? ImageParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
