namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TimeLinePart
/// </summary>
public class TimeLinePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, TimeLinePart
{
  public new DocumentFormat.OpenXml.Packaging.TimeLinePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.TimeLinePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TimeLinePartImpl(): base() {}
  
  public TimeLinePartImpl(DocumentFormat.OpenXml.Packaging.TimeLinePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.TimeLinePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.TimeLinePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
