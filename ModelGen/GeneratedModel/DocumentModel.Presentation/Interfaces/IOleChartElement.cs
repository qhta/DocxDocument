namespace DocumentModel.Presentation;

public interface IOleChartElement // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ChartSubElement? Type { get ; set; }
  
  public uint? Level { get ; set; }
  
}
