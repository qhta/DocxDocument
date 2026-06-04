namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of axis group.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlaxisgroup?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlAxisGroup))]
public enum AxisGroup
{
  /// <summary>
  /// Primary axis group.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlAxisGroup.xlPrimary))]
  Primary = 1,
  /// <summary>
  /// Secondary axis group.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlAxisGroup.xlSecondary))]
  Secondary = 2
}
