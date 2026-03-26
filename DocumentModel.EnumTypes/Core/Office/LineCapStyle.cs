namespace DocumentMode.Office;

/// <summary>
/// Specifies the type of line cap.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinecapstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum LineCapStyle
{
  /// <summary>
  /// Specifies a mixture of line caps.
  /// </summary>
  /// <summary>
  /// Specifies a squared-off line cap.
  /// </summary>
  Square = 1,
  /// <summary>
  /// Specifies a rounded line cap.
  /// </summary>
  Round = 2,
  /// <summary>
  /// Specifies a flat line cap.
  /// </summary>
  Flat = 3
}
