namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineState Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IMovingPeriodState))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ISelectionTimelineRange))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IBoundsTimelineRange))]
public class TimelineState: ITimelineState
{
  /// <summary>
  /// singleRangeFilterState, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? SingleRangeFilterState
  {
    get;
    set;
  }
  
  /// <summary>
  /// minimalRefreshVersion, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? MinimalRefreshVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// lastRefreshVersion, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? LastRefreshVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// pivotCacheId, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? PivotCacheId
  {
    get;
    set;
  }
  
  /// <summary>
  /// filterType, this property is only available in Office 2013 and later.
  /// </summary>
  public PivotFilterValues? FilterType
  {
    get;
    set;
  }
  
  /// <summary>
  /// filterId, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? FilterId
  {
    get;
    set;
  }
  
  /// <summary>
  /// filterTabId, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? FilterTabId
  {
    get;
    set;
  }
  
  /// <summary>
  /// filterPivotName, this property is only available in Office 2013 and later.
  /// </summary>
  public string? FilterPivotName
  {
    get;
    set;
  }
  
  /// <summary>
  /// SelectionTimelineRange.
  /// </summary>
  public ISelectionTimelineRange? SelectionTimelineRange
  {
    get;
    set;
  }
  
  /// <summary>
  /// BoundsTimelineRange.
  /// </summary>
  public IBoundsTimelineRange? BoundsTimelineRange
  {
    get;
    set;
  }
  
  /// <summary>
  /// MovingPeriodState.
  /// </summary>
  public IMovingPeriodState? MovingPeriodState
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Excel.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
