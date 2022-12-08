namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public class DiagramColorsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramColorsPart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramColorsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramColorsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ColorsDefinition? ColorsDefinition
  {
    get;
    set;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
