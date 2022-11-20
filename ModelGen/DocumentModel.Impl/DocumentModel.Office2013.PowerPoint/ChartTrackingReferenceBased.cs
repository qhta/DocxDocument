namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ChartTrackingReferenceBased Class.
/// </summary>
public class ChartTrackingReferenceBased: IChartTrackingReferenceBased
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
