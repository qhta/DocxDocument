namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies paragraph alignment for a text block.
/// </summary>
public enum MsoParagraphAlignment
{
  /// <summary>
  /// Specifies paragraph alignment for a text block.
  /// </summary>
  msoAlignMixed = -2,
  /// <summary>
  /// Specifies that the leftmost character of each line is aligned to the left margin, and the right edge of each
  /// line is ragged. This is the default alignment for paragraphs with left-to-right text direction.
  /// </summary>
  msoAlignLeft = 1,
  /// <summary>
  /// Specifies that the center of each line of text is aligned to the midpoint of the right and left text box
  /// margins, and the left and right edges of each line are ragged.
  /// </summary>
  msoAlignCenter = 2,
  /// <summary>
  /// Specifies that the rightmost character of each line is aligned to the right margin, and the left edge of each
  /// line is ragged. This is the default alignment for paragraphs with right-to-left text direction.
  /// </summary>
  msoAlignRight = 3,
  /// <summary>
  /// Specifies that the first and last characters of each line (except the last) are aligned to the left and right
  /// margins, and lines are filled by adding or subtracting space between and within words. The last line of the
  /// paragraph is aligned to the left margin if text direction is left-to-right, or to the right margin if text
  /// direction is right-to-left. msoAlignDistribute5 Specifies that the first and last characters of each line
  /// (except the last) are aligned to the left and right margins, and lines are filled by adding or subtracting the
  /// same amount from each character. The last line of public enum class MsoParagraphAlignment ﾉ Expand table the
  /// paragraph is aligned to the left margin if text direction is left-to- right, or to the right margin if text
  /// direction is right-to-left. msoAlignThaiDistribute6 Specifies that the first and last characters of each line
  /// (except the last) are aligned to the left and right margins, and lines are filled by adding or subtracting
  /// space between (but not within) words. The last line of the paragraph is aligned to the left margin.
  /// msoAlignJustifyLow7 Specifies the alignment or adjustment of kashida length in Arabic text. Kashida are
  /// special characters used to extend the joiner between two Arabic characters.
  /// </summary>
  msoAlignJustify = 4,
  /// <summary>
  /// Specifies paragraph alignment for a text block.
  /// </summary>
  msoAlignDistribute = 5,
  /// <summary>
  /// Specifies paragraph alignment for a text block.
  /// </summary>
  msoAlignThaiDistribute = 6,
  /// <summary>
  /// Specifies paragraph alignment for a text block.
  /// </summary>
  msoAlignJustifyLow = 7
}
