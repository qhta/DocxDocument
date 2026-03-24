namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of index.
/// </summary>
public enum WdIndexType
{
  /// <summary>
  /// An indented index.
  /// </summary>
  Indent = unchecked((int)0),
  /// <summary>
  /// A run-in index.
  /// </summary>
  Runin = unchecked((int)1)
}
