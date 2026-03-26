namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word interprets high-ANSI text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhighansitext?view=office-pia` for Office interop details.
/// </remarks>
public enum HighAnsiText
{
  /// <summary>
  /// Word doesn't interpret any high-ANSI text as East Asian characters.
  /// </summary>
  HighAnsiIsFarEast = 0,
  /// <summary>
  /// Word interprets all high-ANSI text as East Asian characters.
  /// </summary>
  HighAnsiIsHighAnsi = 1,
  /// <summary>
  /// Microsoft Word interprets high-ANSI text as East Asian characters only if Word automatically detects East
  /// Asian language text.
  /// </summary>
  AutoDetectHighAnsiFarEast = 2
}
