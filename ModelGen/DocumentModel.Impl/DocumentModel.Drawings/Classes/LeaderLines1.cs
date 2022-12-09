namespace DocumentModel.Drawings;

/// <summary>
/// Leader Lines.
/// </summary>
public class LeaderLines1Impl: DocumentModel.Drawings.ChartLinesTypeImpl, LeaderLines1
{
  public new DocumentFormat.OpenXml.Drawing.Charts.LeaderLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LeaderLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
