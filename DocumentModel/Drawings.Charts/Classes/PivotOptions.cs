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
  public Boolean? DropZoneFilter { get; set; }

  /// <summary>
  ///   DropZoneCategories.
  /// </summary>
  public Boolean? DropZoneCategories { get; set; }

  /// <summary>
  ///   DropZoneData.
  /// </summary>
  public Boolean? DropZoneData { get; set; }

  /// <summary>
  ///   DropZoneSeries.
  /// </summary>
  public Boolean? DropZoneSeries { get; set; }

  /// <summary>
  ///   DropZonesVisible.
  /// </summary>
  public Boolean? DropZonesVisible { get; set; }
}