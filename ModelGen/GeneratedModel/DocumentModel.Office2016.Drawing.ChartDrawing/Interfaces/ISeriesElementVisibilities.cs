namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface ISeriesElementVisibilities // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? ConnectorLines { get ; set; }
  
  public bool? MeanLine { get ; set; }
  
  public bool? MeanMarker { get ; set; }
  
  public bool? Nonoutliers { get ; set; }
  
  public bool? Outliers { get ; set; }
  
}
