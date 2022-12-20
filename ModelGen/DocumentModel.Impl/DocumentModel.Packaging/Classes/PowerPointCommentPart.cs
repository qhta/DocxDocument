namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PowerPointCommentPart
/// </summary>
public partial class PowerPointCommentPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, PowerPointCommentPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.PowerPointCommentPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.PowerPointCommentPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PowerPointCommentPartImpl(): base() {}
  
  public PowerPointCommentPartImpl(DocumentFormat.OpenXml.Packaging.PowerPointCommentPart openXmlElement): base(openXmlElement)
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
