namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ImagePart
/// </summary>
public class ImagePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ImagePart
{
  public new DocumentFormat.OpenXml.Packaging.ImagePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ImagePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ImagePartImpl(): base() {}
  
  public ImagePartImpl(DocumentFormat.OpenXml.Packaging.ImagePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ImagePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
