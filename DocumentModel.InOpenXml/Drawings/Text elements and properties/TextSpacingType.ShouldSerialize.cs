namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class TextSpacingType
{
  public bool ShouldSerializeSpacingPercent() => SpacingPercent is not null;
  public bool ShouldSerializeSpacingPoints() => SpacingPoints is not null;
}
