namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the properties of the selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdselectionflags?view=office-pia` for Office interop details.
/// </remarks>
public enum WdSelectionFlags
{
  /// <summary>
  /// The selection is at the start of the active document.
  /// </summary>
  StartActive = 1,
  /// <summary>
  /// The selection is at the end of the letter.
  /// </summary>
  AtEOL = 2,
  /// <summary>
  /// The selection was overtyped.
  /// </summary>
  Overtype = 4,
  /// <summary>
  /// The selection is the active selection.
  /// </summary>
  Active = 8,
  /// <summary>
  /// The selection was replaced.
  /// </summary>
  Replace = 16
}
