namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the formatting from the previous list can be continued.
/// </summary>
public enum WdContinue
{
  /// <summary>
  /// Formatting cannot continue from the previous list.
  /// </summary>
  wdContinueDisabled = unchecked((int)0),
  /// <summary>
  /// Numbering can be restarted.
  /// </summary>
  wdResetList = unchecked((int)1),
  /// <summary>
  /// Formatting can continue from the previous list.
  /// </summary>
  wdContinueList = unchecked((int)2)
}
