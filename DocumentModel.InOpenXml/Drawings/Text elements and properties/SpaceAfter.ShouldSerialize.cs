namespace DocumentModel.Drawings;

public partial class SpaceAfter
{
  public bool ShouldSerializeSpacingPercent() => SpacingPercent is not null;
  public bool ShouldSerializeSpacingPoints() => SpacingPoints is not null;
}
