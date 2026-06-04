namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the dash style for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinedashstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoLineDashStyle))]
public enum LineDashStyle
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineDashStyleMixed))]
  DashStyleMixed = -2,
  /// <summary>
  /// Line is solid.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineSolid))]
  Solid = 1,
  /// <summary>
  /// Line is made up of square dots.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineSquareDot))]
  SquareDot = 2,
  /// <summary>
  /// Line is made up of round dots.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineRoundDot))]
  RoundDot = 3,
  /// <summary>
  /// Line consists of dashes only.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineDash))]
  Dash = 4,
  /// <summary>
  /// Line is a dash-dot pattern.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineDashDot))]
  DashDot = 5,
  /// <summary>
  /// Line is a dash-dot-dot pattern.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineDashDotDot))]
  DashDotDot = 6,
  /// <summary>
  /// Line consists of long dashes.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineLongDash))]
  LongDash = 7,
  /// <summary>
  /// Line is a long dash-dot pattern.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineLongDashDot))]
  LongDashDot = 8,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineLongDashDotDot))]
  LongDashDotDot = 9,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineSysDash))]
  SysDash = 10,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineSysDot))]
  SysDot = 11,
  /// <summary>
  /// public enum class LineDashStyle
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineDashStyle.msoLineSysDashDot))]
  SysDashDot = 12
}
