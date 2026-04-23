namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ExtBaseTableProperties<T> 
{
  public bool ShouldSerializeTableStyle() => !String.IsNullOrEmpty(TableStyle);
  public bool ShouldSerializeTablePositionProperties() => TablePositionProperties is not null && ShouldSerialize(TablePositionProperties);
  public bool ShouldSerializeTableOverlap() => TableOverlap is not null && ShouldSerialize(TableOverlap);
  public bool ShouldSerializeBiDiVisual() => BiDiVisual is not null;
  public bool ShouldSerializeTableCaption() => !String.IsNullOrEmpty(TableCaption);
  public bool ShouldSerializeTableDescription() => !String.IsNullOrEmpty(TableDescription);
}
