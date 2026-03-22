namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an auto macro that is stored in the document.
/// </summary>
public enum WdAutoMacros
{
  /// <summary>
  /// AutoExec macro.
  /// </summary>
  wdAutoExec = unchecked((int)0),
  /// <summary>
  /// AutoNew macro.
  /// </summary>
  wdAutoNew = unchecked((int)1),
  /// <summary>
  /// AutoOpen macro.
  /// </summary>
  wdAutoOpen = unchecked((int)2),
  /// <summary>
  /// AutoClose macro.
  /// </summary>
  wdAutoClose = unchecked((int)3),
  /// <summary>
  /// AutoExit macro.
  /// </summary>
  wdAutoExit = unchecked((int)4),
  /// <summary>
  /// AutoSync macro.
  /// </summary>
  wdAutoSync = unchecked((int)5)
}
