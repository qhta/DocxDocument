namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a paragraph.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdparagraphalignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdParagraphAlignment")]
public enum ParagraphAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphLeft")]
  Left = 0,
  /// <summary>
  /// Center-aligned.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphCenter")]
  Center = 1,
  /// <summary>
  /// Right-aligned.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphRight")]
  Right = 2,
  /// <summary>
  /// Fully justified.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphJustify")]
  Justify = 3,
  /// <summary>
  /// Paragraph characters are distributed to fill the entire width of the paragraph.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphDistribute")]
  Distribute = 4,
  /// <summary>
  /// Justified with a medium character compression ratio.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphJustifyMed")]
  JustifyMed = 5,
  /// <summary>
  /// Justified with a high character compression ratio.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphJustifyHi")]
  JustifyHi = 7,
  /// <summary>
  /// Justified with a low character compression ratio.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphJustifyLow")]
  JustifyLow = 8,
  /// <summary>
  /// Justified according to Thai formatting layout.
  /// </summary>
  [InteropEnumValue("wdAlignParagraphThaiJustify")]
  ThaiJustify = 9
}
