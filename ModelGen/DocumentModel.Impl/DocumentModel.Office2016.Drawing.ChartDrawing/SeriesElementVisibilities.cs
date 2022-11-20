namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the SeriesElementVisibilities Class.
/// </summary>
public class SeriesElementVisibilities: ISeriesElementVisibilities
{
  /// <summary>
  /// connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ConnectorLines
  {
    get;
    set;
  }
  
  /// <summary>
  /// meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? MeanLine
  {
    get;
    set;
  }
  
  /// <summary>
  /// meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? MeanMarker
  {
    get;
    set;
  }
  
  /// <summary>
  /// nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Nonoutliers
  {
    get;
    set;
  }
  
  /// <summary>
  /// outliers, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Outliers
  {
    get;
    set;
  }
  
}
