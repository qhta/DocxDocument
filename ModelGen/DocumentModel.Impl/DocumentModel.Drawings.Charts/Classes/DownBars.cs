namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Down Bars.
/// </summary>
public class DownBarsImpl: DocumentModel.Drawings.Charts.UpDownBarTypeImpl, DownBars
{
  public new DocumentFormat.OpenXml.Drawing.Charts.DownBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DownBars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DownBarsImpl(): base() {}
  
  public DownBarsImpl(DocumentFormat.OpenXml.Drawing.Charts.DownBars openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
