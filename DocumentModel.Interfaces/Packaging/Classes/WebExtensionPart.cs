using DocumentModel.WebExtensions;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WebExtensionPart
/// </summary>
public interface WebExtensionPart: OpenXmlPart
{

  /// <summary>
  ///   Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public ImageParts ImageParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public WebExtension? WebExtension { get; set; }
}