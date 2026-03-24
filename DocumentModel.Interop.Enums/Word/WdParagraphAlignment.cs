namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a paragraph.
/// </summary>
public enum WdParagraphAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  Left = unchecked((int)0),
  /// <summary>
  /// Center-aligned.
  /// </summary>
  Center = unchecked((int)1),
  /// <summary>
  /// Right-aligned.
  /// </summary>
  Right = unchecked((int)2),
  /// <summary>
  /// Fully justified. wdAlignParagraphDistribute4 Paragraph characters are distributed to fill the entire width of
  /// the paragraph. wdAlignParagraphJustifyMed5 Justified with a medium character compression ratio.
  /// wdAlignParagraphJustifyHi7 Justified with a high character compression ratio. wdAlignParagraphJustifyLow8
  /// Justified with a low character compression ratio. wdAlignParagraphThaiJustify9 Justified according to Thai
  /// formatting layout.
  /// </summary>
  Justify = unchecked((int)3),
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  Distribute = unchecked((int)4),
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  JustifyMed = unchecked((int)5),
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  JustifyHi = unchecked((int)7),
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  JustifyLow = unchecked((int)8),
  /// <summary>
  /// Specifies the alignment of a paragraph.
  /// </summary>
  ThaiJustify = unchecked((int)9)
}
