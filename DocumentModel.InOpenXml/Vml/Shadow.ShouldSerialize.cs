namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Shadow
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeObscured() => Obscured is not null;
  public bool ShouldSerializeColor() => !String.IsNullOrEmpty(Color);
  public bool ShouldSerializeOpacity() => !String.IsNullOrEmpty(Opacity);
  public bool ShouldSerializeOffset() => !String.IsNullOrEmpty(Offset);
  public bool ShouldSerializeColor2() => !String.IsNullOrEmpty(Color2);
  public bool ShouldSerializeOffset2() => !String.IsNullOrEmpty(Offset2);
  public bool ShouldSerializeOrigin() => !String.IsNullOrEmpty(Origin);
  public bool ShouldSerializeMatrix() => !String.IsNullOrEmpty(Matrix);
}
