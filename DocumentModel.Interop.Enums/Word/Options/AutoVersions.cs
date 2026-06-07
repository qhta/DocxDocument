namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of the option for automatically saving document versions.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdautoversions?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdAutoVersions")]
public enum AutoVersions
{
  /// <summary>
  /// No document version is saved.
  /// </summary>
  [InteropEnumValue("wdAutoVersionOff")]
  ff = 0,
  /// <summary>
  /// A document version is saved automatically when the document is closed.
  /// </summary>
  [InteropEnumValue("wdAutoVersionOnClose")]
  nClose = 1
}
