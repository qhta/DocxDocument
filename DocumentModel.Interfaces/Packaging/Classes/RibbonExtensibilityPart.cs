namespace DocumentModel.Packaging;

/// <summary>
///   Defines the RibbonExtensibilityPart
/// </summary>
public interface RibbonExtensibilityPart: IModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the RibbonExtensibilityPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }
  public string? RelationshipType { get; set; }
}