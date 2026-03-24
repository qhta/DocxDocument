namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a paragraph.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdparagraphalignment?view=office-pia` for Office interop details.
/// </remarks>
public enum WdParagraphAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Center-aligned.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Right-aligned.
  /// </summary>
  Right = 2,
  /// <summary>
  /// Fully justified. wdAlignParagraphDistribute4 Paragraph characters are distributed to fill the entire width of
  /// the paragraph. wdAlignParagraphJustifyMed5 Justified with a medium character compression ratio.
  /// wdAlignParagraphJustifyHi7 Justified with a high character compression ratio. wdAlignParagraphJustifyLow8
  /// Justified with a low character compression ratio. wdAlignParagraphThaiJustify9 Justified according to Thai
  /// formatting layout.
  /// </summary>
  Justify = 3,
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  Distribute = 4,
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  JustifyMed = 5,
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  JustifyHi = 7,
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  JustifyLow = 8,
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  ThaiJustify = 9
}
