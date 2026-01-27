namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class InlineShape
{
  public bool ShouldSerializeAlternativeText() => AlternativeText is not null;
}
