namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether a command bar is in the first row or last row relative to other command bars in the same
/// docking area.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobarrow?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoBarRow))]
public enum BarRow
{
  /// <summary>
  /// First row of docking area.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarRow.msoBarRowFirst))]
  First = 0,
  /// <summary>
  /// Last row of docking area.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarRow.msoBarRowLast))]
  Last = -1
}
