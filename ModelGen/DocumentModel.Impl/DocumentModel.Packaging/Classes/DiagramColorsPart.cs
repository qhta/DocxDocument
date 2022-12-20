namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public partial class DiagramColorsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramColorsPart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramColorsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramColorsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramColorsPartImpl(): base() {}
  
  public DiagramColorsPartImpl(DocumentFormat.OpenXml.Packaging.DiagramColorsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ColorsDefinition? ColorsDefinition
  {
    get
    {
      if (OpenXmlElement?.ColorsDefinition != null)
        return new DocumentModel.Drawings.Diagrams.ColorsDefinitionImpl(OpenXmlElement.ColorsDefinition);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.Diagrams.ColorsDefinitionImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.ColorsDefinition = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
