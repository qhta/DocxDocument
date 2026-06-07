namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an auto macro that is stored in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdautomacros?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdAutoMacros")]
public enum AutoMacros
{
  /// <summary>
  /// AutoExec macro.
  /// </summary>
  [InteropEnumValue("wdAutoExec")]
  Exec = 0,
  /// <summary>
  /// AutoNew macro.
  /// </summary>
  [InteropEnumValue("wdAutoNew")]
  New = 1,
  /// <summary>
  /// AutoOpen macro.
  /// </summary>
  [InteropEnumValue("wdAutoOpen")]
  Open = 2,
  /// <summary>
  /// AutoClose macro.
  /// </summary>
  [InteropEnumValue("wdAutoClose")]
  Close = 3,
  /// <summary>
  /// AutoExit macro.
  /// </summary>
  [InteropEnumValue("wdAutoExit")]
  Exit = 4,
  /// <summary>
  /// AutoSync macro.
  /// </summary>
  [InteropEnumValue("wdAutoSync")]
  Sync = 5
}
