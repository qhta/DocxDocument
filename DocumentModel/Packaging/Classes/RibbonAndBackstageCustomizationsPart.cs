namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public class RibbonAndBackstageCustomizationsPart: ModelElement
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CustomUI? CustomUI { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }
}