namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
public partial class SlideSyncDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlideSyncDataPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.SlideSyncDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlideSyncDataPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SlideSyncDataPartImpl(): base() {}
  
  public SlideSyncDataPartImpl(DocumentFormat.OpenXml.Packaging.SlideSyncDataPart openXmlElement): base(openXmlElement)
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
