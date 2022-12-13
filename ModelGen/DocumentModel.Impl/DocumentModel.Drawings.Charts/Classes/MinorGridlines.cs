namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Minor Gridlines.
/// </summary>
public class MinorGridlinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, MinorGridlines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MinorGridlinesImpl(): base() {}
  
  public MinorGridlinesImpl(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
