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
  
  public PowerPointCommentPartImpl(): base() {}
  
  public PowerPointCommentPartImpl(DocumentFormat.OpenXml.Packaging.PowerPointCommentPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PowerPointCommentPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PowerPointCommentPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
