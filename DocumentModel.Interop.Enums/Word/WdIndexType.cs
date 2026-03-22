namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of index.
/// </summary>
public enum WdIndexType
{
  /// <summary>
  /// An indented index.
  /// </summary>
  wdIndexIndent = unchecked((int)0),
  /// <summary>
  /// A run-in index.
  /// </summary>
  wdIndexRunin = unchecked((int)1)
}
