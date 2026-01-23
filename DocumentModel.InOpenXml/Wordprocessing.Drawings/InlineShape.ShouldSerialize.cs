namespace DocumentModel.Wordprocessing.Drawings;

public partial class InlineShape
{
  public bool ShouldSerializeAlternativeText() => AlternativeText is not null;
}
