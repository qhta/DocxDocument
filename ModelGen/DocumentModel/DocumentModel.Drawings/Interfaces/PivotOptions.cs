namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public interface PivotOptions
{
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  public Boolean? DropZoneFilter { get ; set; }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  public Boolean? DropZoneCategories { get ; set; }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  public Boolean? DropZoneData { get ; set; }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  public Boolean? DropZoneSeries { get ; set; }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  public Boolean? DropZonesVisible { get ; set; }
  
}
