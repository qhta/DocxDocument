namespace DocumentModel.Packaging;

/// <summary>
/// Defines the RibbonExtensibilityPart
/// </summary>
public partial class RibbonExtensibilityPart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the ImageParts of the RibbonExtensibilityPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  public String? RelationshipType { get; }
  
}
