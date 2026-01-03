namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PivotOptions Class.
/// </summary>
public interface PivotOptions: IModelElement
{
  /// <summary>
  ///   DropZoneFilter.
  /// </summary>
  public bool? DropZoneFilter { get; set; }
  /// <summary>
  ///   DropZoneCategories.
  /// </summary>
  public bool? DropZoneCategories { get; set; }
  /// <summary>
  ///   DropZoneData.
  /// </summary>
  public bool? DropZoneData { get; set; }
  /// <summary>
  ///   DropZoneSeries.
  /// </summary>
  public bool? DropZoneSeries { get; set; }
  /// <summary>
  ///   DropZonesVisible.
  /// </summary>
  public bool? DropZonesVisible { get; set; }
}