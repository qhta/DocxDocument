namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the dash style for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinedashstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum LineDashStyle
{
  /// <summary>
  /// Not supported.
  /// </summary>
  DashStyleMixed = -2,
  /// <summary>
  /// Line is solid.
  /// </summary>
  Solid = 1,
  /// <summary>
  /// Line is made up of square dots.
  /// </summary>
  SquareDot = 2,
  /// <summary>
  /// Line is made up of round dots.
  /// </summary>
  RoundDot = 3,
  /// <summary>
  /// Line consists of dashes only.
  /// </summary>
  Dash = 4,
  /// <summary>
  /// Line is a dash-dot pattern.
  /// </summary>
  DashDot = 5,
  /// <summary>
  /// Line is a dash-dot-dot pattern.
  /// </summary>
  DashDotDot = 6,
  /// <summary>
  /// Line consists of long dashes.
  /// </summary>
  LongDash = 7,
  /// <summary>
  /// Line is a long dash-dot pattern.
  /// </summary>
  LongDashDot = 8,
  /// <summary>
  /// No description is available.
  /// </summary>
  LongDashDotDot = 9,
  /// <summary>
  /// No description is available.
  /// </summary>
  SysDash = 10,
  /// <summary>
  /// No description is available.
  /// </summary>
  SysDot = 11,
  /// <summary>
  /// public enum class LineDashStyle
  /// </summary>
  SysDashDot = 12
}
