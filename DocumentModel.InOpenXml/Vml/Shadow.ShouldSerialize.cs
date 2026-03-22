namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class Shadow
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeObscured() => Obscured is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeOpacity() => Opacity is not null;
  public bool ShouldSerializeOffset() => Offset is not null;
  public bool ShouldSerializeColor2() => Color2 is not null;
  public bool ShouldSerializeOffset2() => Offset2 is not null;
  public bool ShouldSerializeOrigin() => Origin is not null;
  public bool ShouldSerializeMatrix() => Matrix is not null;
}
