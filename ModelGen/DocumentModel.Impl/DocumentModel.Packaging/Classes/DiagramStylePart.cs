namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
public class DiagramStylePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramStylePart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramStylePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramStylePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.StyleDefinition? StyleDefinition
  {
    get;
    set;
  }
  
}
