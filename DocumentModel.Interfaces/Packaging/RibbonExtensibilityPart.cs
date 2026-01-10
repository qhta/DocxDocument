namespace DocumentModel.Packaging;

/// <summary>
///   Defines the RibbonExtensibilityPart
/// </summary>
public interface RibbonExtensibilityPart: OpenXmlPart
{

  /// <summary>
  ///   Gets the ImageParts of the RibbonExtensibilityPart
  /// </summary>
  public ImageParts ImageParts { get; set; }

}