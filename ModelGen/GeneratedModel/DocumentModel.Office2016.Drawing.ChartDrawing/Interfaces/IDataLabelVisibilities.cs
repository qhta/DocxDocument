namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IDataLabelVisibilities // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? SeriesName { get ; set; }
  
  public bool? CategoryName { get ; set; }
  
  public bool? Value { get ; set; }
  
}
