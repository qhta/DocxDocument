namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public class VmlDrawingPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, VmlDrawingPart
{
  public new DocumentFormat.OpenXml.Packaging.VmlDrawingPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VmlDrawingPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public VmlDrawingPartImpl(): base() {}
  
  public VmlDrawingPartImpl(DocumentFormat.OpenXml.Packaging.VmlDrawingPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.VmlDrawingPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public Collection<DocumentModel.Packaging.LegacyDiagramTextPart>? LegacyDiagramTextParts
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
        typeof(DocumentFormat.OpenXml.Packaging.VmlDrawingPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
