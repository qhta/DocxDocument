namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public class DiagramColorsPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, DiagramColorsPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ColorsDefinition? ColorsDefinition
  {
    get;
    set;
  }
  
}
