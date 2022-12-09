namespace DocumentModel.Drawings;

/// <summary>
/// Up Bars.
/// </summary>
public class UpBarsImpl: DocumentModel.Drawings.UpDownBarTypeImpl, UpBars
{
  public new DocumentFormat.OpenXml.Drawing.Charts.UpBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UpBars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
