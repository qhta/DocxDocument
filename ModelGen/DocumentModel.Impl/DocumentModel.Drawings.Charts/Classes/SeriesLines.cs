namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SeriesLines Class.
/// </summary>
public class SeriesLinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, SeriesLines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.SeriesLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SeriesLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SeriesLinesImpl(): base() {}
  
  public SeriesLinesImpl(DocumentFormat.OpenXml.Drawing.Charts.SeriesLines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
