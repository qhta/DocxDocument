namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SeriesElementVisibilities Class.
/// </summary>
public interface ISeriesElementVisibilities // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? ConnectorLines { get ; set; }
  
  /// <summary>
  /// meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? MeanLine { get ; set; }
  
  /// <summary>
  /// meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? MeanMarker { get ; set; }
  
  /// <summary>
  /// nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? Nonoutliers { get ; set; }
  
  /// <summary>
  /// outliers, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? Outliers { get ; set; }
  
}
