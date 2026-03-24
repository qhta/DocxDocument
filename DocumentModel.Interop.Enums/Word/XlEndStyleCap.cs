namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the end style for error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlendstylecap?view=office-pia` for Office interop details.
/// </remarks>
public enum XlEndStyleCap
{
  /// <summary>
  /// Caps applied.
  /// </summary>
  Cap = 1,
  /// <summary>
  /// No caps applied.
  /// </summary>
  NoCap = 2
}
