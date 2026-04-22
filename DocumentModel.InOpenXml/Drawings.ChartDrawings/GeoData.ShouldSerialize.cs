namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoData
{
  public bool ShouldSerializeEntityName() => !String.IsNullOrEmpty(EntityName);
  public bool ShouldSerializeEntityId() => !String.IsNullOrEmpty(EntityId);
  public bool ShouldSerializeEast() => East is not null;
  public bool ShouldSerializeWest() => West is not null;
  public bool ShouldSerializeNorth() => North is not null;
  public bool ShouldSerializeSouth() => South is not null;
  public bool ShouldSerializeGeoPolygons() => GeoPolygons is not null;
  public bool ShouldSerializeCopyrights() => Copyrights is not null;
}
