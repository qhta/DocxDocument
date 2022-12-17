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
    get
    {
      if (OpenXmlElement?.DataModelRoot != null)
        return new DocumentModel.Drawings.Diagrams.DataModelRootImpl(OpenXmlElement.DataModelRoot);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.Diagrams.DataModelRootImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.DataModelRoot = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts
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
  public Collection<DocumentModel.Packaging.SlidePart>? SlideParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WorksheetPart>? WorksheetParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
