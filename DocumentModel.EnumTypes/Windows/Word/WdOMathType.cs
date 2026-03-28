namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the display format type of equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathType
{
  /// <summary>
  /// Professional format.
  /// </summary>
  Display = 0,
  /// <summary>
  /// Inline.
  /// </summary>
  Inline = 1
}
