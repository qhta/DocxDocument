namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the dash style for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinedashstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoLineDashStyle")]
public enum LineDashStyle
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoLineDashStyleMixed")]
  DashStyleMixed = -2,
  /// <summary>
  /// Line is solid.
  /// </summary>
  [OfficeInteropEnumValue("msoLineSolid")]
  Solid = 1,
  /// <summary>
  /// Line is made up of square dots.
  /// </summary>
  [OfficeInteropEnumValue("msoLineSquareDot")]
  SquareDot = 2,
  /// <summary>
  /// Line is made up of round dots.
  /// </summary>
  [OfficeInteropEnumValue("msoLineRoundDot")]
  RoundDot = 3,
  /// <summary>
  /// Line consists of dashes only.
  /// </summary>
  [OfficeInteropEnumValue("msoLineDash")]
  Dash = 4,
  /// <summary>
  /// Line is a dash-dot pattern.
  /// </summary>
  [OfficeInteropEnumValue("msoLineDashDot")]
  DashDot = 5,
  /// <summary>
  /// Line is a dash-dot-dot pattern.
  /// </summary>
  [OfficeInteropEnumValue("msoLineDashDotDot")]
  DashDotDot = 6,
  /// <summary>
  /// Line consists of long dashes.
  /// </summary>
  [OfficeInteropEnumValue("msoLineLongDash")]
  LongDash = 7,
  /// <summary>
  /// Line is a long dash-dot pattern.
  /// </summary>
  [OfficeInteropEnumValue("msoLineLongDashDot")]
  LongDashDot = 8,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoLineLongDashDotDot")]
  LongDashDotDot = 9,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoLineSysDash")]
  SysDash = 10,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoLineSysDot")]
  SysDot = 11,
  /// <summary>
  /// public enum class LineDashStyle
  /// </summary>
  [OfficeInteropEnumValue("msoLineSysDashDot")]
  SysDashDot = 12
}
