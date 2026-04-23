namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocGrid
{
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
  public bool ShouldSerializeLinePitch() => LinePitch is not null && ShouldSerialize(LinePitch);
  public bool ShouldSerializeCharacterSpace() => CharacterSpace is not null && ShouldSerialize(CharacterSpace);
}
