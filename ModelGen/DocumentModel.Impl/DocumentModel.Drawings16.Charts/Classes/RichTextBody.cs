namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
public class RichTextBodyImpl: DocumentModel.Drawings16.Charts.TextBodyType2Impl, RichTextBody
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
