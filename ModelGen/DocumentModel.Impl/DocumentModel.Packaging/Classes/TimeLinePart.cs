namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TimeLinePart
/// </summary>
public partial class TimeLinePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, TimeLinePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.TimeLinePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.TimeLinePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TimeLinePartImpl(): base() {}
  
  public TimeLinePartImpl(DocumentFormat.OpenXml.Packaging.TimeLinePart openXmlElement): base(openXmlElement)
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
