namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HighLowLines Class.
/// </summary>
public class HighLowLinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, HighLowLines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.HighLowLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.HighLowLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
