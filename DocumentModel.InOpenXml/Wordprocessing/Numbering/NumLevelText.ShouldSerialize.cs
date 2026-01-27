namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumLevelText
{
  public bool ShouldSerializeText() => Text is not null;
}
