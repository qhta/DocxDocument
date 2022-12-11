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
  
  public UpBarsImpl(): base() {}
  
  public UpBarsImpl(DocumentFormat.OpenXml.Drawing.Charts.UpBars openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
