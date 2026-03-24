namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an auto macro that is stored in the document.
/// </summary>
public enum WdAutoMacros
{
  /// <summary>
  /// AutoExec macro.
  /// </summary>
  Exec = unchecked((int)0),
  /// <summary>
  /// AutoNew macro.
  /// </summary>
  New = unchecked((int)1),
  /// <summary>
  /// AutoOpen macro.
  /// </summary>
  Open = unchecked((int)2),
  /// <summary>
  /// AutoClose macro.
  /// </summary>
  Close = unchecked((int)3),
  /// <summary>
  /// AutoExit macro.
  /// </summary>
  Exit = unchecked((int)4),
  /// <summary>
  /// AutoSync macro.
  /// </summary>
  Sync = unchecked((int)5)
}
