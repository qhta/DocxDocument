namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Border
{
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
  public bool ShouldSerializeArtStyle() => !String.IsNullOrEmpty(ArtStyle);
  public bool ShouldSerializeColor() => Color is not null && ShouldSerialize(Color);
  public bool ShouldSerializeWidth() => Width is not null && ShouldSerialize(Width);
  public bool ShouldSerializeSpace() => Space is not null && ShouldSerialize(Space);
  public bool ShouldSerializeShadow() => Shadow is not null;
  public bool ShouldSerializeFrame() => Frame is not null;
}
