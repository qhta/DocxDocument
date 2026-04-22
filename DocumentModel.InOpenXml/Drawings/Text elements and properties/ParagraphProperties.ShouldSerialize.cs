namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ParagraphProperties
{
  public bool ShouldSerializeLeftMargin() => LeftMargin is not null;
  public bool ShouldSerializeRightMargin() => RightMargin is not null;
  public bool ShouldSerializeLevel() => Level is not null;
  public bool ShouldSerializeIndent() => Indent is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
  public bool ShouldSerializeDefaultTabSize() => DefaultTabSize is not null;
  public bool ShouldSerializeRightToLeft() => RightToLeft is not null;
  public bool ShouldSerializeEastAsianLineBreak() => EastAsianLineBreak is not null;
  public bool ShouldSerializeFontAlignment() => FontAlignment is not null;
  public bool ShouldSerializeLatinLineBreak() => LatinLineBreak is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializeLineSpacing() => LineSpacing is not null;
  public bool ShouldSerializeSpaceBefore() => SpaceBefore is not null;
  public bool ShouldSerializeSpaceAfter() => SpaceAfter is not null;
}
