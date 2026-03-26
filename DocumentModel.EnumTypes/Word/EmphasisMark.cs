namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of emphasis mark to use for a character or designated character string.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdemphasismark?view=office-pia` for Office interop details.
/// </remarks>
public enum EmphasisMark
{
  /// <summary>
  /// No emphasis mark.
  /// </summary>
  None = 0,
  /// <summary>
  /// A solid black circle.
  /// </summary>
  OverSolidCircle = 1,
  /// <summary>
  /// A comma.
  /// </summary>
  OverComma = 2,
  /// <summary>
  /// An empty white circle.
  /// </summary>
  OverWhiteCircle = 3,
  /// <summary>
  /// A solid black circle.
  /// </summary>
  UnderSolidCircle = 4
}
