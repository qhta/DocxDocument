namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class ExtBaseTableProperties<T> 
{
  public bool ShouldSerializeTableStyle() => TableStyle is not null;
  public bool ShouldSerializeTablePositionProperties() => TablePositionProperties is not null;
  public bool ShouldSerializeTableOverlap() => TableOverlap is not null;
  public bool ShouldSerializeBiDiVisual() => BiDiVisual is not null;
  public bool ShouldSerializeTableCaption() => TableCaption is not null;
  public bool ShouldSerializeTableDescription() => TableDescription is not null;
}
