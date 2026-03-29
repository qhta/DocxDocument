namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies paragraph alignment for a text block.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum ParagraphAlignment
{
  /// <summary>
  /// Specifies that the leftmost character of each line is aligned to the left margin, and the right edge of each line
  /// is ragged. This is the default alignment for paragraphs with left-to-right text direction.
  /// </summary>
  /// <summary>
  /// Specifies that the leftmost character of each line is aligned to the left margin, and the right edge of each
  /// line is ragged. This is the default alignment for paragraphs with left-to-right text direction.
  /// </summary>
  [OpenXmlEnumValue("Left")]
  Left,
  /// <summary>
  /// Specifies that the center of each line of text is aligned to the midpoint of the right and left text box
  /// margins, and the left and right edges of each line are ragged.
  /// </summary>
  [OpenXmlEnumValue("Center")]
  Center,
  /// <summary>
  /// Specifies that the rightmost character of each line is aligned to the right margin, and the left edge of each
  /// line is ragged. This is the default alignment for paragraphs with right-to-left text direction.
  /// </summary>
  [OpenXmlEnumValue("Right")]
  Right,
  /// <summary>
  /// Specifies that the first and last characters of each line (except the last) are aligned to the left and right
  /// margins, and lines are filled by adding or subtracting space between and within words. The last line of the
  /// paragraph is aligned to the left margin if text direction is left-to-right, or to the right margin if text
  /// direction is right-to-left. msoAlignDistribute5 Specifies that the first and last characters of each line
  /// (except the last) are aligned to the left and right margins, and lines are filled by adding or subtracting the
  /// same amount from each character. The last line of public enum class ParagraphAlignment ﾉ Expand table the
  /// paragraph is aligned to the left margin if text direction is left-to- right, or to the right margin if text
  /// direction is right-to-left. msoAlignThaiDistribute6 Specifies that the first and last characters of each line
  /// (except the last) are aligned to the left and right margins, and lines are filled by adding or subtracting
  /// space between (but not within) words. The last line of the paragraph is aligned to the left margin.
  /// msoAlignJustifyLow7 Specifies the alignment or adjustment of kashida length in Arabic text. Kashida are
  /// special characters used to extend the joiner between two Arabic characters.
  /// </summary>
  [OpenXmlEnumValue("Justify")]
  Justify,
  /// <summary>
  /// Specifies that the first and last characters of each line (except the last) are aligned to the left
  /// and right margins,  and lines are filled by adding or subtracting the same amount from each character.
  /// The last line of the paragraph is aligned to the left margin if text direction is left-to-right,
  /// or to the right margin if text direction is right-to-left.
  /// </summary>
  [OpenXmlEnumValue("Distribute")]
  Distribute,
  /// <summary>
  /// Justified with a medium character compression ratio.
  /// </summary>
  JustifyMed,
  /// <summary>
  /// Justified with a high character compression ratio.
  /// </summary>
  JustifyHi,
  /// <summary>
  /// Justified with a low character compression ratio.
  /// </summary>
  JustifyLow,
  /// <summary>
  /// Justified according to Thai formatting layout.
  /// </summary>
  ThaiJustify
}
