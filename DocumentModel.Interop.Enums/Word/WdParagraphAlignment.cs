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
  /// Fully justified.
  /// </summary>
  Justify = 3,
  /// <summary>
  /// Paragraph characters are distributed to fill the entire width of the paragraph.
  /// </summary>
  Distribute = 4,
  /// <summary>
  /// Justified with a medium character compression ratio.
  /// </summary>
  JustifyMed = 5,
  /// <summary>
  /// Justified with a high character compression ratio.
  /// </summary>
  JustifyHi = 7,
  /// <summary>
  /// Justified with a low character compression ratio.
  /// </summary>
  JustifyLow = 8,
  /// <summary>
  /// Justified according to Thai formatting layout.
  /// </summary>
  ThaiJustify = 9
}
