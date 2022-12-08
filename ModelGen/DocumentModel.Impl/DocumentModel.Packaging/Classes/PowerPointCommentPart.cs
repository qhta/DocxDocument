namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PowerPointCommentPart
/// </summary>
public class PowerPointCommentPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, PowerPointCommentPart
{
  public new DocumentFormat.OpenXml.Packaging.PowerPointCommentPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.PowerPointCommentPart?)_OpenXmlElement;
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
