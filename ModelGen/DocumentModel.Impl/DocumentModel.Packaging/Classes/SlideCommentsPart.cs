namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideCommentsPart
/// </summary>
public class SlideCommentsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlideCommentsPart
{
  public new DocumentFormat.OpenXml.Packaging.SlideCommentsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlideCommentsPart?)_OpenXmlElement;
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
