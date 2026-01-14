namespace DocumentModel.Drawings;

/// <summary>
///   Represents properties for a text paragraph, including margins, indentation, alignment, tab size, line breaks, font alignment, spacing, and other formatting options.
/// </summary>
public class ParagraphProperties: ModelElement
{
  /// <summary>
  ///   Left margin of the paragraph.
  /// </summary>
  public Int32? LeftMargin { get; set; }

  /// <summary>
  ///   Right margin of the paragraph.
  /// </summary>
  public Int32? RightMargin { get; set; }

  /// <summary>
  ///   Outline level of the paragraph.
  /// </summary>
  public Int32? Level { get; set; }

  /// <summary>
  ///   Indentation value for the paragraph.
  /// </summary>
  public Int32? Indent { get; set; }

  /// <summary>
  ///   Alignment of the paragraph text.
  /// </summary>
  public TextAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Default tab size for the paragraph.
  /// </summary>
  public Int32? DefaultTabSize { get; set; }

  /// <summary>
  ///   Indicates right-to-left text direction.
  /// </summary>
  public bool? RightToLeft { get; set; }

  /// <summary>
  ///   Enables East Asian line break rules.
  /// </summary>
  public bool? EastAsianLineBreak { get; set; }

  /// <summary>
  ///   Font alignment within the paragraph.
  /// </summary>
  public TextFontAlignmentKind? FontAlignment { get; set; }

  /// <summary>
  ///   Enables Latin line break rules.
  /// </summary>
  public bool? LatinLineBreak { get; set; }

  /// <summary>
  ///   Enables hanging punctuation.
  /// </summary>
  public bool? Height { get; set; }

  /// <summary>
  ///   Line spacing for the paragraph.
  /// </summary>
  public LineSpacing? LineSpacing { get; set; }

  /// <summary>
  ///   Space before the paragraph.
  /// </summary>
  public SpaceBefore? SpaceBefore { get; set; }

  /// <summary>
  ///   Space after the paragraph.
  /// </summary>
  public SpaceAfter? SpaceAfter { get; set; }
}