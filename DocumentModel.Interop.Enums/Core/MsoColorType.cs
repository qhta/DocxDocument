namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocolortype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoColorType
{
  /// <summary>
  /// Specifies the color type.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Color is determined by values of red, green, and blue. msoColorTypeScheme2 Color is defined by an
  /// application-specific scheme.
  /// </summary>
  RGB = 1,
  /// <summary>
  /// Specifies the color type.
  /// </summary>
  Scheme = 2,
  /// <summary>
  /// Color is determined by values of cyan, magenta, yellow, and black.
  /// </summary>
  CMYK = 3,
  /// <summary>
  /// Color Management System color type.
  /// </summary>
  CMS = 4,
  /// <summary>
  /// Not supported.
  /// </summary>
  Ink = 5
}
