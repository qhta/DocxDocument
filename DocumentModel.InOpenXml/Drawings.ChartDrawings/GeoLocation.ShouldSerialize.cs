namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoLocation
{
  public bool ShouldSerializeLatitude() => Latitude is not null;
  public bool ShouldSerializeLongitude() => Longitude is not null;
  public bool ShouldSerializeEntityName() => !String.IsNullOrEmpty(EntityName);
  public bool ShouldSerializeEntityType() => EntityType is not null;
  public bool ShouldSerializeAddress() => Address is not null;
}
