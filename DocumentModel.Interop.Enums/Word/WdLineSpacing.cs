namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a line spacing format to be applied to a paragraph.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinespacing?view=office-pia` for Office interop details.
/// </remarks>
public enum LineSpacing
{
  /// <summary>
  /// Single spaced. default
  /// </summary>
  Single = 0,
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  OnePtFive = 1,
  /// <summary>
  /// Double spaced.
  /// </summary>
  Double = 2,
  /// <summary>
  /// Line spacing is always at least a specified amount. The amount is specified separately.
  /// </summary>
  AtLeast = 3,
  /// <summary>
  /// Line spacing is only the exact maximum amount of space required. This setting commonly uses less space than
  /// single spacing.
  /// </summary>
  Exactly = 4,
  /// <summary>
  /// Line spacing determined by the number of lines indicated.
  /// </summary>
  Multiple = 5
}
