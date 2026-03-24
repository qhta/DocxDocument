namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the formatting from the previous list can be continued.
/// </summary>
public enum WdContinue
{
  /// <summary>
  /// Formatting cannot continue from the previous list.
  /// </summary>
  ContinueDisabled = unchecked((int)0),
  /// <summary>
  /// Numbering can be restarted.
  /// </summary>
  ResetList = unchecked((int)1),
  /// <summary>
  /// Formatting can continue from the previous list.
  /// </summary>
  ContinueList = unchecked((int)2)
}
