namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
public class DiagramLayoutDefinitionPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, DiagramLayoutDefinitionPart
{
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.LayoutDefinition? LayoutDefinition
  {
    get;
    set;
  }
  
}
