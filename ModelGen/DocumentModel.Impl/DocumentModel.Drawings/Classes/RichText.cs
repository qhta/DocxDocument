namespace DocumentModel.Drawings;

/// <summary>
/// Rich Text.
/// </summary>
public class RichTextImpl: DocumentModel.Drawings.TextBodyType1Impl, RichText
{
  public new DocumentFormat.OpenXml.Drawing.Charts.RichText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RichText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override BodyProperties? BodyProperties
  {
    get;
    set;
  }
  
  public override ListStyle? ListStyle
  {
    get;
    set;
  }
  
  public Collection<Paragraph>? Paragraphs
  {
    get;
    set;
  }
  
}
