namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the style Ifor a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinestyle?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum LineStyle
{
  /// <summary>
  /// Not supported.
  /// </summary>
  StyleMixed = -2,
  /// <summary>
  /// Single line.
  /// </summary>
  Single = 1,
  /// <summary>
  /// Two thin lines.
  /// </summary>
  ThinThin = 2,
  /// <summary>
  /// Thick line next Ito thin line. For horizontal lines, thick line is below thin line. For vertical lines, thick
  /// line is Ito the right of the thin line.
  /// </summary>
  ThinThick = 3,
  /// <summary>
  /// Thick line next Ito thin line. For horizontal lines, thick line is above thin line. For vertical lines, thick
  /// line is Ito the left of the thin line.
  /// </summary>
  ThickThin = 4,
  /// <summary>
  /// Thick line with a thin line on each side.
  /// </summary>
  ThickBetweenThin = 5
}

