namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a paragraph.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdparagraphalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdParagraphAlignment")]
public enum ParagraphAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphLeft")]
  Left = 0,
  /// <summary>
  /// Center-aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphCenter")]
  Center = 1,
  /// <summary>
  /// Right-aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphRight")]
  Right = 2,
  /// <summary>
  /// Fully justified.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphJustify")]
  Justify = 3,
  /// <summary>
  /// Paragraph characters are distributed to fill the entire width of the paragraph.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphDistribute")]
  Distribute = 4,
  /// <summary>
  /// Justified with a medium character compression ratio.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphJustifyMed")]
  JustifyMed = 5,
  /// <summary>
  /// Justified with a high character compression ratio.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphJustifyHi")]
  JustifyHi = 7,
  /// <summary>
  /// Justified with a low character compression ratio.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphJustifyLow")]
  JustifyLow = 8,
  /// <summary>
  /// Justified according to Thai formatting layout.
  /// </summary>
  [WordInteropEnumValue("wdAlignParagraphThaiJustify")]
  ThaiJustify = 9
}
