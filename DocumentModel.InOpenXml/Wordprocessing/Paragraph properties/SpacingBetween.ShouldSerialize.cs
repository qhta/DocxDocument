namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SpacingBetween
{
  public bool ShouldSerializeLine() => Line is not null;
  public bool ShouldSerializeLineRule() => LineRule is not null;
}
