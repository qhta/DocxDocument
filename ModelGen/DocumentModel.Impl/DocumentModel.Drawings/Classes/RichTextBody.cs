namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
public class RichTextBodyImpl: DocumentModel.Drawings.TextBodyType2Impl, RichTextBody
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Paragraph>? Paragraphs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
