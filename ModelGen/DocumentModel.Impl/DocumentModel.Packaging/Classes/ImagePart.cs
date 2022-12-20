namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ImagePart
/// </summary>
public partial class ImagePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ImagePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.ImagePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ImagePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ImagePartImpl(): base() {}
  
  public ImagePartImpl(DocumentFormat.OpenXml.Packaging.ImagePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
