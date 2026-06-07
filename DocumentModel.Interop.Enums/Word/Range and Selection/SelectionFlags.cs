namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the properties of the selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdselectionflags?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSelectionFlags")]
public enum SelectionFlags
{
  /// <summary>
  /// The selection is at the start of the active document.
  /// </summary>
  [InteropEnumValue("wdSelStartActive")]
  StartActive = 1,
  /// <summary>
  /// The selection is at the end of the letter.
  /// </summary>
  [InteropEnumValue("wdSelAtEOL")]
  AtEOL = 2,
  /// <summary>
  /// The selection was overtyped.
  /// </summary>
  [InteropEnumValue("wdSelOvertype")]
  Overtype = 4,
  /// <summary>
  /// The selection is the active selection.
  /// </summary>
  [InteropEnumValue("wdSelActive")]
  Active = 8,
  /// <summary>
  /// The selection was replaced.
  /// </summary>
  [InteropEnumValue("wdSelReplace")]
  Replace = 16
}
