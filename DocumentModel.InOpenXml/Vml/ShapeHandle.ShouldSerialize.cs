namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class ShapeHandle
{
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializePolar() => Polar is not null;
  public bool ShouldSerializeMap() => Map is not null;
  public bool ShouldSerializeInvertX() => InvertX is not null;
  public bool ShouldSerializeInvertY() => InvertY is not null;
  public bool ShouldSerializeSwitch() => Switch is not null;
  public bool ShouldSerializeXRange() => XRange is not null;
  public bool ShouldSerializeYRange() => YRange is not null;
  public bool ShouldSerializeRadiusRange() => RadiusRange is not null;
}
