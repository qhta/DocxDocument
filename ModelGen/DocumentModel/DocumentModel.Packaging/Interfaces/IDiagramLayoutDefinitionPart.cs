namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
public interface IDiagramLayoutDefinitionPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public IImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawing.ILayoutDefinition? LayoutDefinition { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
