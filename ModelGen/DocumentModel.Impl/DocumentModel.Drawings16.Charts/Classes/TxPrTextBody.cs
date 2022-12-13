namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public class TxPrTextBodyImpl: DocumentModel.Drawings16.Charts.TextBodyType2Impl, TxPrTextBody
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TxPrTextBodyImpl(): base() {}
  
  public TxPrTextBodyImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody openXmlElement): base(openXmlElement)
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
