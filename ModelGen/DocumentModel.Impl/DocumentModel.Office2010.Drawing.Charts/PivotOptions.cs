namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IDropZoneFilter))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IDropZoneCategories))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IDropZoneData))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IDropZoneSeries))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IDropZonesVisible))]
public class PivotOptions: IPivotOptions
{
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  public IDropZoneFilter? DropZoneFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  public IDropZoneCategories? DropZoneCategories
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  public IDropZoneData? DropZoneData
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  public IDropZoneSeries? DropZoneSeries
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  public IDropZonesVisible? DropZonesVisible
  {
    get;
    set;
  }
  
}
