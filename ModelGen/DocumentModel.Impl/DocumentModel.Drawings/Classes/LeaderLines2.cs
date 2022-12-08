namespace DocumentModel.Drawings;

/// <summary>
/// Leader Lines.
/// </summary>
public class LeaderLines2Impl: DocumentModel.Drawings.ChartLinesTypeImpl, LeaderLines2
{
  public new DocumentFormat.OpenXml.Drawing.Charts.LeaderLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LeaderLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
