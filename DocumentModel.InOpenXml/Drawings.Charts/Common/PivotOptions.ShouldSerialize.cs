namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class PivotOptions
{
  public bool ShouldSerializeDropZoneFilter() => DropZoneFilter is not null;
  public bool ShouldSerializeDropZoneCategories() => DropZoneCategories is not null;
  public bool ShouldSerializeDropZoneData() => DropZoneData is not null;
  public bool ShouldSerializeDropZoneSeries() => DropZoneSeries is not null;
  public bool ShouldSerializeDropZonesVisible() => DropZonesVisible is not null;
}
