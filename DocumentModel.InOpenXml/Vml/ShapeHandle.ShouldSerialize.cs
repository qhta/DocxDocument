namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class ShapeHandle
{
  public bool ShouldSerializePosition() => !String.IsNullOrEmpty(Position);
  public bool ShouldSerializePolar() => !String.IsNullOrEmpty(Polar);
  public bool ShouldSerializeMap() => !String.IsNullOrEmpty(Map);
  public bool ShouldSerializeInvertX() => InvertX is not null;
  public bool ShouldSerializeInvertY() => InvertY is not null;
  public bool ShouldSerializeSwitch() => Switch is not null;
  public bool ShouldSerializeXRange() => !String.IsNullOrEmpty(XRange);
  public bool ShouldSerializeYRange() => !String.IsNullOrEmpty(YRange);
  public bool ShouldSerializeRadiusRange() => !String.IsNullOrEmpty(RadiusRange);
}
