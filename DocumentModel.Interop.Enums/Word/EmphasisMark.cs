namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of emphasis mark to use for a character or designated character string.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdemphasismark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdEmphasisMark))]
public enum WdEmphasisMark
{
  /// <summary>
  /// No emphasis mark.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEmphasisMark.wdEmphasisMarkNone))]
  None = 0,
  /// <summary>
  /// A solid black circle.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEmphasisMark.wdEmphasisMarkOverSolidCircle))]
  OverSolidCircle = 1,
  /// <summary>
  /// A comma.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEmphasisMark.wdEmphasisMarkOverComma))]
  OverComma = 2,
  /// <summary>
  /// An empty white circle.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEmphasisMark.wdEmphasisMarkOverWhiteCircle))]
  OverWhiteCircle = 3,
  /// <summary>
  /// A solid black circle.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEmphasisMark.wdEmphasisMarkUnderSolidCircle))]
  UnderSolidCircle = 4
}
