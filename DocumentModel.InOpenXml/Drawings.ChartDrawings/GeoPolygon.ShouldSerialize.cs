namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoPolygon
{
  public bool ShouldSerializePolygonId() => !String.IsNullOrEmpty(PolygonId);
  public bool ShouldSerializeNumPoints() => NumPoints is not null;
  public bool ShouldSerializePcaRings() => !String.IsNullOrEmpty(PcaRings);
}
