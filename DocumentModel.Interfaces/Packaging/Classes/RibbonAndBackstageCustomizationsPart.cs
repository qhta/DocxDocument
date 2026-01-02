namespace DocumentModel.Packaging;

/// <summary>
///   Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public class RibbonAndBackstageCustomizationsPart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CustomUI? CustomUI { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }
  public string? RelationshipType { get; set; }
}