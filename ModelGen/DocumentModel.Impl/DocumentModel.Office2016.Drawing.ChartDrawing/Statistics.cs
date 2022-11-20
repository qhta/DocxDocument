namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public class Statistics: IStatistics
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public QuartileMethod? QuartileMethod
  {
    get;
    set;
  }
  
}
