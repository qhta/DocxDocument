namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies paragraph alignment for a text block.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoparagraphalignment?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoParagraphAlignment")]
public enum ParagraphAlignment
{
  /// <summary>
  /// Use a combination of alignment styles.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies that the leftmost character of each line is aligned to the left margin, and the right edge of each
  /// line is ragged. This is the default alignment for paragraphs with left-to-right text direction.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignLeft")]
  Left = 1,
  /// <summary>
  /// Specifies that the center of each line of text is aligned to the midpoint of the right and left text box
  /// margins, and the left and right edges of each line are ragged.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignCenter")]
  Center = 2,
  /// <summary>
  /// Specifies that the rightmost character of each line is aligned to the right margin, and the left edge of each
  /// line is ragged. This is the default alignment for paragraphs with right-to-left text direction.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignRight")]
  Right = 3,
  /// <summary>
  /// Specifies that the first and last characters of each line (except the last) are aligned to the left and right
  /// margins, and lines are filled by adding or subtracting space between and within words. The last line of the
  /// paragraph is aligned to the left margin if text direction is left-to-right, or to the right margin if text
  /// direction is right-to-left.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignJustify")]
  Justify = 4,
  /// <summary>
  /// Specifies that the first and last characters of each line (except the last) are aligned to the left and right
  /// margins, and lines are filled by adding or subtracting the same amount from each character. The last line of
  /// </summary>
  [OfficeInteropEnumValue("msoAlignDistribute")]
  Distribute = 5,
  /// <summary>
  /// Specifies that the first and last characters of each line (except the last) are aligned to the left and right
  /// margins, and lines are filled by adding or subtracting space between (but not within) words. The last line of
  /// the paragraph is aligned to the left margin.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignThaiDistribute")]
  ThaiDistribute = 6,
  /// <summary>
  /// Specifies the alignment or adjustment of kashida length in Arabic text. Kashida are special characters used to
  /// extend the joiner between two Arabic characters.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignJustifyLow")]
  JustifyLow = 7
}
