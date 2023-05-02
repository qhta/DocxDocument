using DocumentModel.WebExtensions.UI;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WebExTaskpanesPart
/// </summary>
public class WebExTaskpanesPart: ModelElement
{
  public string? ContentType { get; set; }

  public string? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Taskpanes? Taskpanes { get; set; }

  /// <summary>
  ///   Gets the WebExtensionParts of the WebExTaskpanesPart
  /// </summary>
  public Collection<WebExtensionPart>? WebExtensionParts { get; set; }
}