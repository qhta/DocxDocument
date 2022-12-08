namespace DocumentModel.Drawings;

/// <summary>
/// Major Gridlines.
/// </summary>
public class MajorGridlinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, MajorGridlines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
