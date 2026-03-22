namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class DocGrid
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeLinePitch() => LinePitch is not null;
  public bool ShouldSerializeCharacterSpace() => CharacterSpace is not null;
}
