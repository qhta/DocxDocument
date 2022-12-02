namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelVisibilities Class.
/// </summary>
public interface IDataLabelVisibilities // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? SeriesName { get ; set; }
  
  /// <summary>
  /// categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? CategoryName { get ; set; }
  
  /// <summary>
  /// value, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Value { get ; set; }
  
}
