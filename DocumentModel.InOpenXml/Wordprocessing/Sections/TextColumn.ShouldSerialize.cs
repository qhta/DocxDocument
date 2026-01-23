namespace DocumentModel.Wordprocessing;

public partial class TextColumn
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeSpace() => Space is not null;
}
