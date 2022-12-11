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
  
  public HighLowLinesImpl(): base() {}
  
  public HighLowLinesImpl(DocumentFormat.OpenXml.Drawing.Charts.HighLowLines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
