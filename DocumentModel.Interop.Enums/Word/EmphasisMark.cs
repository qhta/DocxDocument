namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of emphasis mark to use for a character or designated character string.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdemphasismark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdEmphasisMark")]
public enum WdEmphasisMark
{
  /// <summary>
  /// No emphasis mark.
  /// </summary>
  [WordInteropEnumValue("wdEmphasisMarkNone")]
  None = 0,
  /// <summary>
  /// A solid black circle.
  /// </summary>
  [WordInteropEnumValue("wdEmphasisMarkOverSolidCircle")]
  OverSolidCircle = 1,
  /// <summary>
  /// A comma.
  /// </summary>
  [WordInteropEnumValue("wdEmphasisMarkOverComma")]
  OverComma = 2,
  /// <summary>
  /// An empty white circle.
  /// </summary>
  [WordInteropEnumValue("wdEmphasisMarkOverWhiteCircle")]
  OverWhiteCircle = 3,
  /// <summary>
  /// A solid black circle.
  /// </summary>
  [WordInteropEnumValue("wdEmphasisMarkUnderSolidCircle")]
  UnderSolidCircle = 4
}
