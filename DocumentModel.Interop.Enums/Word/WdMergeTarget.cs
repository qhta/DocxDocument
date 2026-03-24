namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the target for a Compare and Merge Documents process.
/// </summary>
public enum WdMergeTarget
{
  /// <summary>
  /// Merge into selected document.
  /// </summary>
  Selected = 0,
  /// <summary>
  /// Merge into current document.
  /// </summary>
  Current = 1,
  /// <summary>
  /// Merge into new document.
  /// </summary>
  New = 2
}
