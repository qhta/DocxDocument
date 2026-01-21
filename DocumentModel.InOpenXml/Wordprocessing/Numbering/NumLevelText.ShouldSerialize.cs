namespace DocumentModel.Wordprocessing;

public partial class NumLevelText
{
  public bool ShouldSerializeText() => Text is not null;
}
