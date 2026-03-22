namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number of replacements to be made when find and replace is used.
/// </summary>
public enum WdReplace
{
  /// <summary>
  /// Replace no occurrences.
  /// </summary>
  wdReplaceNone = unchecked((int)0),
  /// <summary>
  /// Replace the first occurrence encountered.
  /// </summary>
  wdReplaceOne = unchecked((int)1),
  /// <summary>
  /// Replace all occurrences.
  /// </summary>
  wdReplaceAll = unchecked((int)2)
}
