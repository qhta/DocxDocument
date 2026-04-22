namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Geography
{
  public bool ShouldSerializeProjectionType() => ProjectionType is not null;
  public bool ShouldSerializeViewedRegionType() => ViewedRegionType is not null;
  public bool ShouldSerializeCultureLanguage() => !String.IsNullOrEmpty(CultureLanguage);
  public bool ShouldSerializeCultureRegion() => !String.IsNullOrEmpty(CultureRegion);
  public bool ShouldSerializeAttribution() => !String.IsNullOrEmpty(Attribution);
  public bool ShouldSerializeGeoCache() => GeoCache is not null;
}
