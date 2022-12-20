namespace DocumentModel.Packaging;

/// <summary>
/// Defines the XmlSignaturePart
/// </summary>
public partial class XmlSignaturePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, XmlSignaturePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.XmlSignaturePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.XmlSignaturePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public XmlSignaturePartImpl(): base() {}
  
  public XmlSignaturePartImpl(DocumentFormat.OpenXml.Packaging.XmlSignaturePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
