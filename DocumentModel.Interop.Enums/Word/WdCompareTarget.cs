namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the target document for displaying document comparison differences.
/// </summary>
public enum WdCompareTarget
{
  /// <summary>
  /// Specifies the target document for displaying document comparison differences.
  /// </summary>
  Selected = unchecked((int)0),
  /// <summary>
  /// Places comparison differences in the current document. Default.
  /// </summary>
  Current = unchecked((int)1),
  /// <summary>
  /// Places comparison differences in a new document.
  /// </summary>
  New = unchecked((int)2)
}
