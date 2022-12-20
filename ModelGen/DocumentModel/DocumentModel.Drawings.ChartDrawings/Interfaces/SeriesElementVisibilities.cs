namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the SeriesElementVisibilities Class.
/// </summary>
public partial interface SeriesElementVisibilities
{
  /// <summary>
  /// connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? ConnectorLines { get; set; }
  
  /// <summary>
  /// meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? MeanLine { get; set; }
  
  /// <summary>
  /// meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? MeanMarker { get; set; }
  
  /// <summary>
  /// nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Nonoutliers { get; set; }
  
  /// <summary>
  /// outliers, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Outliers { get; set; }
  
}
