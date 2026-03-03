namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SpacingInterlines
{
  public bool ShouldSerializeLine() => Line is not null;
  public bool ShouldSerializeLineRule() => LineRule is not null;
}
