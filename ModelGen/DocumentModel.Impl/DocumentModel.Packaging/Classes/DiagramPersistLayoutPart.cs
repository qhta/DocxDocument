namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramPersistLayoutPart
/// </summary>
public class DiagramPersistLayoutPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramPersistLayoutPart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramPersistLayoutPartImpl(): base() {}
  
  public DiagramPersistLayoutPartImpl(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Office.Drawing? Drawing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
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
        typeof(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
