namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextParagraphPropertiesType Class.
/// </summary>
public class TextParagraphPropertiesType: ModelElement
{
  /// <summary>
  ///   Left Margin
  /// </summary>
  public Int32? LeftMargin { get; set; }

  /// <summary>
  ///   Right Margin
  /// </summary>
  public Int32? RightMargin { get; set; }

  /// <summary>
  ///   Level
  /// </summary>
  public Int32? Level { get; set; }

  /// <summary>
  ///   Indent
  /// </summary>
  public Int32? Indent { get; set; }

  /// <summary>
  ///   Alignment
  /// </summary>
  public TextAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Default Tab Size
  /// </summary>
  public Int32? DefaultTabSize { get; set; }

  /// <summary>
  ///   Right To Left
  /// </summary>
  public bool? RightToLeft { get; set; }

  /// <summary>
  ///   East Asian Line Break
  /// </summary>
  public bool? EastAsianLineBreak { get; set; }

  /// <summary>
  ///   Font Alignment
  /// </summary>
  public TextFontAlignmentKind? FontAlignment { get; set; }

  /// <summary>
  ///   Latin Line Break
  /// </summary>
  public bool? LatinLineBreak { get; set; }

  /// <summary>
  ///   Hanging Punctuation
  /// </summary>
  public bool? Height { get; set; }

  /// <summary>
  ///   Line Spacing.
  /// </summary>
  public LineSpacing? LineSpacing { get; set; }

  /// <summary>
  ///   Space Before.
  /// </summary>
  public SpaceBefore? SpaceBefore { get; set; }

  /// <summary>
  ///   Space After.
  /// </summary>
  public SpaceAfter? SpaceAfter { get; set; }
}