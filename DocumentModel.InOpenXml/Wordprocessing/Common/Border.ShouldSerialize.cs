namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Border
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeSpace() => Space is not null;
  public bool ShouldSerializeShadow() => Shadow is not null;
  public bool ShouldSerializeFrame() => Frame is not null;
}
