namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a line spacing format to be applied to a paragraph.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinespacing?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLineSpacing
{
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  Single = 0,
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  OnePtFive = 1,
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  Double = 2,
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  AtLeast = 3,
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  Exactly = 4,
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  Multiple = 5
}
