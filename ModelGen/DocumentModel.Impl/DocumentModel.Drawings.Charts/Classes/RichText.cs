namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Rich Text.
/// </summary>
public class RichTextImpl: DocumentModel.Drawings.Charts.TextBodyTypeImpl, RichText
{
  public new DocumentFormat.OpenXml.Drawing.Charts.RichText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RichText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RichTextImpl(): base() {}
  
  public RichTextImpl(DocumentFormat.OpenXml.Drawing.Charts.RichText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Paragraph? Paragraph
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
