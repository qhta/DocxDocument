namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public class TextProperties2Impl: DocumentModel.Drawings.TextBodyType1Impl, TextProperties2
{
  public new DocumentFormat.OpenXml.Drawing.Charts.TextProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.TextProperties?)_OpenXmlElement;
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
