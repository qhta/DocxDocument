namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the DataLabelVisibilities Class.
/// </summary>
public interface IDataLabelVisibilities // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? SeriesName { get ; set; }
  
  /// <summary>
  /// categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? CategoryName { get ; set; }
  
  /// <summary>
  /// value, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Value { get ; set; }
  
}
