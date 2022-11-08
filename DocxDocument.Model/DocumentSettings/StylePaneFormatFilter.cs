namespace DocxDocument.Model;

[Flags]
public enum StylePaneFormatFilter
{
  ClearFormatting = 0,
  AlternateStyleNames = 1,
  CustomStyles = 2,
  DirectFormattingOnNumbering = 4,
  DirectFormattingOnParagraphs = 8,
  DirectFormattingOnRuns = 16,
  DirectFormattingOnTables = 32,
  HeadingStyles = 64,
  LatentStyles = 128,
  NumberingStyles = 256,
  StylesInUse = 512,
  TableStyles = 1024,
  Top3HeadingStyles = 2048,
  VisibleStyles = 4096,
  AllStyles = 0x3FFF,

}