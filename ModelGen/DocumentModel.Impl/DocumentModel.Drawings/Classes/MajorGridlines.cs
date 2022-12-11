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
  
  public MajorGridlinesImpl(): base() {}
  
  public MajorGridlinesImpl(DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
