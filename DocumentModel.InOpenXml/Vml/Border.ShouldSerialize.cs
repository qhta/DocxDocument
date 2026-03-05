namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Border
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeShadow() => Shadow is not null;
}
