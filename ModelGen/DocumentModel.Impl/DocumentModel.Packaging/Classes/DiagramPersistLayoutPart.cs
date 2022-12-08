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
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Drawing? Drawing
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public ImagePart? ImageParts
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
