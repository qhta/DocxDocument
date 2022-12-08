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
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
