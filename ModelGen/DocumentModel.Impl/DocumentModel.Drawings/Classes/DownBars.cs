namespace DocumentModel.Drawings;

/// <summary>
/// Down Bars.
/// </summary>
public class DownBarsImpl: DocumentModel.Drawings.UpDownBarTypeImpl, DownBars
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
  
  public new ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
