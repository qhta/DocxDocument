namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies how many replacements to make.
/// </summary>
public enum ReplaceKind
{
  /// <summary>Do not replace, only find</summary>
  None = 0,
  /// <summary>Replace only the first occurrence found</summary>
  One = 1,
  /// <summary>Replace all occurrences</summary>
  All = 2
}