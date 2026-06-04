namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an auto macro that is stored in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdautomacros?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdAutoMacros))]
public enum AutoMacros
{
  /// <summary>
  /// AutoExec macro.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAutoMacros.wdAutoExec))]
  Exec = 0,
  /// <summary>
  /// AutoNew macro.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAutoMacros.wdAutoNew))]
  New = 1,
  /// <summary>
  /// AutoOpen macro.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAutoMacros.wdAutoOpen))]
  Open = 2,
  /// <summary>
  /// AutoClose macro.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAutoMacros.wdAutoClose))]
  Close = 3,
  /// <summary>
  /// AutoExit macro.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAutoMacros.wdAutoExit))]
  Exit = 4,
  /// <summary>
  /// AutoSync macro.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAutoMacros.wdAutoSync))]
  Sync = 5
}
