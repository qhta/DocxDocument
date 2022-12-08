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
  
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
