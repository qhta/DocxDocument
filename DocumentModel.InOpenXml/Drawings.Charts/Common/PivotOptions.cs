namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PivotOptions Class.
/// </summary>
[OpenXmlType(typeof(DXO10DC.PivotOptions))]
[DataContract]
[XmlRoot("PivotOptions", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PivotOptions: ModelElement<DXO10DC.PivotOptions>
{
  /// <summary>
  ///   DropZoneFilter.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DC.PivotOptions.DropZoneFilter))]
  public bool? DropZoneFilter
  {
    get => _DropZoneFilter ??= GetProperty<bool?>(GetUpdatableElement()?.DropZoneFilter);
    set => UpdateField(ref _DropZoneFilter, value, nameof(DropZoneFilter));
  }

  private bool? _DropZoneFilter;

  /// <summary>
  ///   DropZoneCategories.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DC.PivotOptions.DropZoneCategories))]
  public bool? DropZoneCategories
  {
    get => _DropZoneCategories ??= GetProperty<bool?>(GetUpdatableElement()?.DropZoneCategories);
    set => UpdateField(ref _DropZoneCategories, value, nameof(DropZoneCategories));
  }

  private bool? _DropZoneCategories;

  /// <summary>
  ///   DropZoneData.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DC.PivotOptions.DropZoneData))]
  public bool? DropZoneData
  {
    get => _DropZoneData ??= GetProperty<bool?>(GetUpdatableElement()?.DropZoneData);
    set => UpdateField(ref _DropZoneData, value, nameof(DropZoneData));
  }

  private bool? _DropZoneData;

  /// <summary>
  ///   DropZoneSeries.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DC.PivotOptions.DropZoneSeries))]
  public bool? DropZoneSeries
  {
    get => _DropZoneSeries ??= GetProperty<bool?>(GetUpdatableElement()?.DropZoneSeries);
    set => UpdateField(ref _DropZoneSeries, value, nameof(DropZoneSeries));
  }

  private bool? _DropZoneSeries;

  /// <summary>
  ///   DropZonesVisible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DC.PivotOptions.DropZonesVisible))]
  public bool? DropZonesVisible
  {
    get => _DropZonesVisible ??= GetProperty<bool?>(GetUpdatableElement()?.DropZonesVisible);
    set => UpdateField(ref _DropZonesVisible, value, nameof(DropZonesVisible));
  }

  private bool? _DropZonesVisible;
}