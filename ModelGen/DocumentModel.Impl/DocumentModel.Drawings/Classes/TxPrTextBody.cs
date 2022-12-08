namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public class TxPrTextBodyImpl: DocumentModel.Drawings.TextBodyType2Impl, TxPrTextBody
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody?)_OpenXmlElement;
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
