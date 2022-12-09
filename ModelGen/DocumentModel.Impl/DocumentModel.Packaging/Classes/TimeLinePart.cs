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
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.TimeLinePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.TimeLinePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
