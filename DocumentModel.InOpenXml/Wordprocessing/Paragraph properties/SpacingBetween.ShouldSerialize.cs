namespace DocumentModel.Wordprocessing;

public partial class SpacingBetween
{
  public bool ShouldSerializeLine() => Line is not null;
  public bool ShouldSerializeLineRule() => LineRule is not null;
}
