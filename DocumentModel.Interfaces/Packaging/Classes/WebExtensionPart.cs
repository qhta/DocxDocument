using DocumentModel.WebExtensions;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WebExtensionPart
/// </summary>
public class WebExtensionPart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public WebExtension? WebExtension { get; set; }
}