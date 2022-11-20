namespace DocumentModel.Office2021.Excel.RichValueRefreshIntervals;

/// <summary>
/// Defines the RichValueRefreshInterval Class.
/// </summary>
public class RichValueRefreshInterval: IRichValueRefreshInterval
{
  /// <summary>
  /// resourceIdInt, this property is only available in Office 2021 and later.
  /// </summary>
  public int? ResourceIdInt
  {
    get;
    set;
  }
  
  /// <summary>
  /// resourceIdStr, this property is only available in Office 2021 and later.
  /// </summary>
  public string? ResourceIdStr
  {
    get;
    set;
  }
  
  /// <summary>
  /// interval, this property is only available in Office 2021 and later.
  /// </summary>
  public int? Interval
  {
    get;
    set;
  }
  
}
