namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the display format type of equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOMathType")]
public enum OMathType
{
  /// <summary>
  /// Professional format.
  /// </summary>
  [InteropEnumValue("wdOMathDisplay")]
  Display = 0,
  /// <summary>
  /// Inline.
  /// </summary>
  [InteropEnumValue("wdOMathInline")]
  Inline = 1
}
