namespace DocumentModel.Wordprocessing;

public partial class BorderType
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeShadow() => Shadow is not null;
}
