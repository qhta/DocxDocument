namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the end style for error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlendstylecap?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlEndStyleCap")]
public enum EndStyleCap
{
  /// <summary>
  /// Caps applied.
  /// </summary>
  [WordInteropEnumValue("xlCap")]
  Cap = 1,
  /// <summary>
  /// No caps applied.
  /// </summary>
  [WordInteropEnumValue("xlNoCap")]
  NoCap = 2
}
