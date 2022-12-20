namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideCommentsPart
/// </summary>
public partial class SlideCommentsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlideCommentsPart
{
  public new DocumentFormat.OpenXml.Packaging.SlideCommentsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlideCommentsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SlideCommentsPartImpl(): base() {}
  
  public SlideCommentsPartImpl(DocumentFormat.OpenXml.Packaging.SlideCommentsPart openXmlElement): base(openXmlElement)
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
