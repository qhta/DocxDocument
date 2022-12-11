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
  
  public RichTextBodyImpl(): base() {}
  
  public RichTextBodyImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody openXmlElement): base(openXmlElement)
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
