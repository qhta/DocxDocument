namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the display format type of equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOMathType))]
public enum OMathType
{
  /// <summary>
  /// Professional format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathType.wdOMathDisplay))]
  Display = 0,
  /// <summary>
  /// Inline.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathType.wdOMathInline))]
  Inline = 1
}
