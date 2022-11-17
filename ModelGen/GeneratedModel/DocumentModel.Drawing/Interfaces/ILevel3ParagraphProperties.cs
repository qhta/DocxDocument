namespace DocumentModel.Drawing;

public interface ILevel3ParagraphProperties // : DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType
{
  public int? LeftMargin { get ; set; }

  public int? RightMargin { get ; set; }

  public int? Level { get ; set; }

  public int? Indent { get ; set; }

  public TextAlignmentType? Alignment { get ; set; }

  public int? DefaultTabSize { get ; set; }

  public bool? RightToLeft { get ; set; }

  public bool? EastAsianLineBreak { get ; set; }

  public TextFontAlignment? FontAlignment { get ; set; }

  public bool? LatinLineBreak { get ; set; }

  public bool? Height { get ; set; }

  public ILineSpacing? LineSpacing { get ; set; }

  public ISpaceBefore? SpaceBefore { get ; set; }

  public ISpaceAfter? SpaceAfter { get ; set; }

}
