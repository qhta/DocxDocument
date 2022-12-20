namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThumbnailPart
/// </summary>
public partial class ThumbnailPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ThumbnailPart
{
  public new DocumentFormat.OpenXml.Packaging.ThumbnailPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ThumbnailPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ThumbnailPartImpl(): base() {}
  
  public ThumbnailPartImpl(DocumentFormat.OpenXml.Packaging.ThumbnailPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
