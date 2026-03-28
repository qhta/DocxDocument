namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a statistic to return from a selection or item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstatistic?view=office-pia` for Office interop details.
/// </remarks>
public enum Statistic
{
  /// <summary>
  /// Count of words.
  /// </summary>
  Words = 0,
  /// <summary>
  /// Count of lines.
  /// </summary>
  Lines = 1,
  /// <summary>
  /// Count of pages.
  /// </summary>
  Pages = 2,
  /// <summary>
  /// Count of characters.
  /// </summary>
  Characters = 3,
  /// <summary>
  /// Count of paragraphs.
  /// </summary>
  Paragraphs = 4,
  /// <summary>
  /// Count of characters including spaces.
  /// </summary>
  CharactersWithSpaces = 5,
  /// <summary>
  /// Count of Far East characters.
  /// </summary>
  FarEastCharacters = 6
}
