namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word interprets high-ANSI text.
/// </summary>
public enum WdHighAnsiText
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
