namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Interline
{
  public bool ShouldSerializeLine() => Line is not null && ShouldSerialize(Line);
  public bool ShouldSerializeLineRule() => LineRule is not null && ShouldSerialize(LineRule);
}
