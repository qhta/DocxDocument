namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the end style for error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlendstylecap?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlEndStyleCap")]
public enum EndStyleCap
{
  /// <summary>
  /// Caps applied.
  /// </summary>
  [InteropEnumValue("xlCap")]
  Cap = 1,
  /// <summary>
  /// No caps applied.
  /// </summary>
  [InteropEnumValue("xlNoCap")]
  NoCap = 2
}
