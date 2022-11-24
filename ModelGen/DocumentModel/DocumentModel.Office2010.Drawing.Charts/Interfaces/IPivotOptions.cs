namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public interface IPivotOptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  public IDropZoneFilter? DropZoneFilter { get ; set; }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  public IDropZoneCategories? DropZoneCategories { get ; set; }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  public IDropZoneData? DropZoneData { get ; set; }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  public IDropZoneSeries? DropZoneSeries { get ; set; }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  public IDropZonesVisible? DropZonesVisible { get ; set; }
  
}
