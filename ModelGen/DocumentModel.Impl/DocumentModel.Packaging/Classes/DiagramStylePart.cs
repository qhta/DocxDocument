namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
public class DiagramStylePartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, DiagramStylePart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.StyleDefinition? StyleDefinition
  {
    get;
    set;
  }
  
}
