namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WebExtensionPart
/// </summary>
public partial class WebExtensionPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtension? WebExtension { get; set; }
  
}
