namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TextColumn
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeSpace() => Space is not null;
}
