namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an auto macro that is stored in the document.
/// </summary>
public enum WdAutoMacros
{
  /// <summary>
  /// AutoExec macro.
  /// </summary>
  Exec = 0,
  /// <summary>
  /// AutoNew macro.
  /// </summary>
  New = 1,
  /// <summary>
  /// AutoOpen macro.
  /// </summary>
  Open = 2,
  /// <summary>
  /// AutoClose macro.
  /// </summary>
  Close = 3,
  /// <summary>
  /// AutoExit macro.
  /// </summary>
  Exit = 4,
  /// <summary>
  /// AutoSync macro.
  /// </summary>
  Sync = 5
}
