namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the properties of the selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdselectionflags?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSelectionFlags")]
public enum SelectionFlags
{
  /// <summary>
  /// The selection is at the start of the active document.
  /// </summary>
  [WordInteropEnumValue("wdSelStartActive")]
  StartActive = 1,
  /// <summary>
  /// The selection is at the end of the letter.
  /// </summary>
  [WordInteropEnumValue("wdSelAtEOL")]
  AtEOL = 2,
  /// <summary>
  /// The selection was overtyped.
  /// </summary>
  [WordInteropEnumValue("wdSelOvertype")]
  Overtype = 4,
  /// <summary>
  /// The selection is the active selection.
  /// </summary>
  [WordInteropEnumValue("wdSelActive")]
  Active = 8,
  /// <summary>
  /// The selection was replaced.
  /// </summary>
  [WordInteropEnumValue("wdSelReplace")]
  Replace = 16
}
