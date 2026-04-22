namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class LegacyNumbering
{
  public bool ShouldSerializeSpace() => Space is not null;
  public bool ShouldSerializeIndent() => Indent is not null;
}
