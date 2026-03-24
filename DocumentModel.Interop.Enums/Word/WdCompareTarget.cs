namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the target document for displaying document comparison differences.
/// </summary>
public enum WdCompareTarget
{
  /// <summary>
  /// Specifies the target document for displaying document comparison differences.
  /// </summary>
  Selected = 0,
  /// <summary>
  /// Places comparison differences in the current document. Default.
  /// </summary>
  Current = 1,
  /// <summary>
  /// Places comparison differences in a new document.
  /// </summary>
  New = 2
}
