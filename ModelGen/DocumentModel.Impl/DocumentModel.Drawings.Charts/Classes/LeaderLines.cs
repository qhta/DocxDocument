namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Leader Lines.
/// </summary>
public class LeaderLinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, LeaderLines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.LeaderLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LeaderLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LeaderLinesImpl(): base() {}
  
  public LeaderLinesImpl(DocumentFormat.OpenXml.Drawing.Charts.LeaderLines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
