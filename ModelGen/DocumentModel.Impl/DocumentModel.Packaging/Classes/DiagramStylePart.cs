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
  
  public DiagramStylePartImpl(): base() {}
  
  public DiagramStylePartImpl(DocumentFormat.OpenXml.Packaging.DiagramStylePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DiagramStylePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DiagramStylePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.StyleDefinition? StyleDefinition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
