namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PivotOptions Class.
/// </summary>
public class PivotOptions: ModelElement
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