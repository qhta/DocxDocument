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
  
  public SlideCommentsPartImpl(): base() {}
  
  public SlideCommentsPartImpl(DocumentFormat.OpenXml.Packaging.SlideCommentsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SlideCommentsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SlideCommentsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
