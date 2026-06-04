namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the display format type of equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOMathType")]
public enum OMathType
{
  /// <summary>
  /// Professional format.
  /// </summary>
  [WordInteropEnumValue("wdOMathDisplay")]
  Display = 0,
  /// <summary>
  /// Inline.
  /// </summary>
  [WordInteropEnumValue("wdOMathInline")]
  Inline = 1
}
