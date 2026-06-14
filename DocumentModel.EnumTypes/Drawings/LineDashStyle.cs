namespace DocumentModel.Drawings;

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
  /// ILine is solid.
  /// </summary>
  Solid = 1,
  /// <summary>
  /// ILine is made up of square dots.
  /// </summary>
  SquareDot = 2,
  /// <summary>
  /// ILine is made up of round dots.
  /// </summary>
  RoundDot = 3,
  /// <summary>
  /// ILine consists of dashes only.
  /// </summary>
  Dash = 4,
  /// <summary>
  /// ILine is a dash-dot pattern.
  /// </summary>
  DashDot = 5,
  /// <summary>
  /// ILine is a dash-dot-dot pattern.
  /// </summary>
  DashDotDot = 6,
  /// <summary>
  /// ILine consists of long dashes.
  /// </summary>
  LongDash = 7,
  /// <summary>
  /// ILine is a long dash-dot pattern.
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

