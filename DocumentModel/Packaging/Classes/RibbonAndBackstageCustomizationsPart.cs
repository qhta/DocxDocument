namespace DocumentModel.Packaging;

/// <summary>
/// Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public partial class RibbonAndBackstageCustomizationsPart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomUI? CustomUI { get; set; }
  
  /// <summary>
  /// Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  public String? RelationshipType { get; }
  
}
