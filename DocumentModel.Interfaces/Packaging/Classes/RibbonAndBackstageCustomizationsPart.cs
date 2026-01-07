namespace DocumentModel.Packaging;

/// <summary>
///   Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public interface RibbonAndBackstageCustomizationsPart: OpenXmlPart
{

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CustomUI? CustomUI { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  public ImageParts ImageParts { get; set; }

}