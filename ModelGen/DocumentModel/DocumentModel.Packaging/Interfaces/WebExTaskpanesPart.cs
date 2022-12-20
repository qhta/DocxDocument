namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebExTaskpanesPart
/// </summary>
public partial interface WebExTaskpanesPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.WebExtensions.UI.Taskpanes? Taskpanes { get; set; }
  
  /// <summary>
  /// Gets the WebExtensionParts of the WebExTaskpanesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WebExtensionPart>? WebExtensionParts { get; }
  
}
