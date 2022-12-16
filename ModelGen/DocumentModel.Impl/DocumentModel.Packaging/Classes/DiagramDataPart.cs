namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public class DiagramDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramDataPart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramDataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramDataPartImpl(): base() {}
  
  public DiagramDataPartImpl(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DiagramDataPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.DataModelRoot? DataModelRoot
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DiagramDataPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public DocumentModel.Packaging.SlidePart? SlideParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public DocumentModel.Packaging.WorksheetPart? WorksheetParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
