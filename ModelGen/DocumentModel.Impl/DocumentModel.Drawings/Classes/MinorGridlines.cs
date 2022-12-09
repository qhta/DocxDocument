namespace DocumentModel.Drawings;

/// <summary>
/// Minor Gridlines.
/// </summary>
public class MinorGridlinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, MinorGridlines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
