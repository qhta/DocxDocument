namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingLevelText
{
  public bool ShouldSerializeText() => !String.IsNullOrEmpty(Text);
}
