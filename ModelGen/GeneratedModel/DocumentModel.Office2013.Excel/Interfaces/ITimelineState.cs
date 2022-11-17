namespace DocumentModel.Office2013.Excel;

public interface ITimelineState // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? SingleRangeFilterState { get ; set; }
  
  public uint? MinimalRefreshVersion { get ; set; }
  
  public uint? LastRefreshVersion { get ; set; }
  
  public uint? PivotCacheId { get ; set; }
  
  public PivotFilter? FilterType { get ; set; }
  
  public uint? FilterId { get ; set; }
  
  public uint? FilterTabId { get ; set; }
  
  public string? FilterPivotName { get ; set; }
  
  public ISelectionTimelineRange? SelectionTimelineRange { get ; set; }
  
  public IBoundsTimelineRange? BoundsTimelineRange { get ; set; }
  
  public IMovingPeriodState? MovingPeriodState { get ; set; }
  
  public DocumentModel.Office2013.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
