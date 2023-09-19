namespace DocumentModel.Packaging;


/// <summary>
///   Defines the RibbonExtensibilityPart
/// </summary>
public partial class RibbonExtensibilityPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets the ImageParts of the RibbonExtensibilityPart
  /// </summary>
  public Collection? ImageParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
