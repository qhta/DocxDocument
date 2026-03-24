namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number of replacements to be made when find and replace is used.
/// </summary>
public enum WdReplace
{
  /// <summary>
  /// Replace no occurrences.
  /// </summary>
  None = 0,
  /// <summary>
  /// Replace the first occurrence encountered.
  /// </summary>
  One = 1,
  /// <summary>
  /// Replace all occurrences.
  /// </summary>
  All = 2
}
