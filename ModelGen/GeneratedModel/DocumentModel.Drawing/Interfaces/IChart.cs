namespace DocumentModel.Drawing;

public interface IChart // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public int? SeriesIndex { get ; set; }
  
  public int? CategoryIndex { get ; set; }
  
  public ChartBuildStep? BuildStep { get ; set; }
  
}
