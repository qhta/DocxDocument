namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the dash style for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinedashstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoLineDashStyle")]
public enum LineDashStyle
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoLineDashStyleMixed")]
  DashStyleMixed = -2,
  /// <summary>
  /// Line is solid.
  /// </summary>
  [InteropEnumValue("msoLineSolid")]
  Solid = 1,
  /// <summary>
  /// Line is made up of square dots.
  /// </summary>
  [InteropEnumValue("msoLineSquareDot")]
  SquareDot = 2,
  /// <summary>
  /// Line is made up of round dots.
  /// </summary>
  [InteropEnumValue("msoLineRoundDot")]
  RoundDot = 3,
  /// <summary>
  /// Line consists of dashes only.
  /// </summary>
  [InteropEnumValue("msoLineDash")]
  Dash = 4,
  /// <summary>
  /// Line is a dash-dot pattern.
  /// </summary>
  [InteropEnumValue("msoLineDashDot")]
  DashDot = 5,
  /// <summary>
  /// Line is a dash-dot-dot pattern.
  /// </summary>
  [InteropEnumValue("msoLineDashDotDot")]
  DashDotDot = 6,
  /// <summary>
  /// Line consists of long dashes.
  /// </summary>
  [InteropEnumValue("msoLineLongDash")]
  LongDash = 7,
  /// <summary>
  /// Line is a long dash-dot pattern.
  /// </summary>
  [InteropEnumValue("msoLineLongDashDot")]
  LongDashDot = 8,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoLineLongDashDotDot")]
  LongDashDotDot = 9,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoLineSysDash")]
  SysDash = 10,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoLineSysDot")]
  SysDot = 11,
  /// <summary>
  /// public enum class LineDashStyle
  /// </summary>
  [InteropEnumValue("msoLineSysDashDot")]
  SysDashDot = 12
}
