namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Break
{
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
  public bool ShouldSerializeClear() => Clear is not null && ShouldSerialize(Clear);
}
