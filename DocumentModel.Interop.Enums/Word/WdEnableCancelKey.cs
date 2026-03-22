namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether CTRL+BREAK can or cannot interrupt a macro
/// </summary>
public enum WdEnableCancelKey
{
  /// <summary>
  /// Prevents CTRL+BREAK from interrupting a macro.
  /// </summary>
  wdCancelDisabled = unchecked((int)0),
  /// <summary>
  /// Allows a macro to be interrupted by CTRL+BREAK.
  /// </summary>
  wdCancelInterrupt = unchecked((int)1)
}
