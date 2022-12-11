namespace DocumentModel.Drawings;

/// <summary>
/// Rich Text.
/// </summary>
public class RichTextImpl: DocumentModel.Drawings.TextBodyTypeImpl, RichText
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
  
  public new BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Paragraph? Paragraph
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
