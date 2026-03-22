namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class StylePaneFormatFilter
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeAllStyles() => AllStyles is not null;
  public bool ShouldSerializeCustomStyles() => CustomStyles is not null;
  public bool ShouldSerializeLatentStyles() => LatentStyles is not null;
  public bool ShouldSerializeStylesInUse() => StylesInUse is not null;
  public bool ShouldSerializeHeadingStyles() => HeadingStyles is not null;
  public bool ShouldSerializeNumberingStyles() => NumberingStyles is not null;
  public bool ShouldSerializeTableStyles() => TableStyles is not null;
  public bool ShouldSerializeDirectFormattingOnRuns() => DirectFormattingOnRuns is not null;
  public bool ShouldSerializeDirectFormattingOnParagraphs() => DirectFormattingOnParagraphs is not null;
  public bool ShouldSerializeDirectFormattingOnNumbering() => DirectFormattingOnNumbering is not null;
  public bool ShouldSerializeDirectFormattingOnTables() => DirectFormattingOnTables is not null;
  public bool ShouldSerializeClearFormatting() => ClearFormatting is not null;
  public bool ShouldSerializeTop3HeadingStyles() => Top3HeadingStyles is not null;
  public bool ShouldSerializeVisibleStyles() => VisibleStyles is not null;
  public bool ShouldSerializeAlternateStyleNames() => AlternateStyleNames is not null;
}
