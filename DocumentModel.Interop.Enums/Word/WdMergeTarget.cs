namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the target for a Compare and Merge Documents process.
/// </summary>
public enum WdMergeTarget
{
  /// <summary>
  /// Merge into selected document.
  /// </summary>
  wdMergeTargetSelected = unchecked((int)0),
  /// <summary>
  /// Merge into current document.
  /// </summary>
  wdMergeTargetCurrent = unchecked((int)1),
  /// <summary>
  /// Merge into new document.
  /// </summary>
  wdMergeTargetNew = unchecked((int)2)
}
