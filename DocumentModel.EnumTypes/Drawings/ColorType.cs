namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the color type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocolortype?view=office-pia` for Office interop details.
/// </remarks>
public enum ColorTypeEnum
{
  /// <summary>
  /// Not supported.
  /// </summary>
  /// <summary>
  /// Color is determined by values of red, green, and blue.
  /// </summary>
  RGB = 1,
  /// <summary>
  /// Color is defined by an application-specific scheme.
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

