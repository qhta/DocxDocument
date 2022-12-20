namespace DocumentModel.Packaging;

/// <summary>
/// Called from constructors of derived parts to initialize the IFixedContentTypePart interface. All derived parts must be parts that have fixed content type.
/// </summary>
public partial class IFixedContentTypePartImpl: ModelObjectImpl, IFixedContentTypePart
{
  public DocumentFormat.OpenXml.Packaging.IFixedContentTypePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.IFixedContentTypePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public IFixedContentTypePartImpl(): base() {}
  
  public IFixedContentTypePartImpl(DocumentFormat.OpenXml.Packaging.IFixedContentTypePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
}
