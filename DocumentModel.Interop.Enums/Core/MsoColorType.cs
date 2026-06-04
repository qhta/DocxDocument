namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocolortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoColorType")]
public enum ColorType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoColorTypeMixed")]
  Mixed = -2,
  /// <summary>
  /// Color is determined by values of red, green, and blue.
  /// </summary>
  [OfficeInteropEnumValue("msoColorTypeRGB")]
  RGB = 1,
  /// <summary>
  /// Color is defined by an application-specific scheme.
  /// </summary>
  [OfficeInteropEnumValue("msoColorTypeScheme")]
  Scheme = 2,
  /// <summary>
  /// Color is determined by values of cyan, magenta, yellow, and black.
  /// </summary>
  [OfficeInteropEnumValue("msoColorTypeCMYK")]
  CMYK = 3,
  /// <summary>
  /// Color Management System color type.
  /// </summary>
  [OfficeInteropEnumValue("msoColorTypeCMS")]
  CMS = 4,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoColorTypeInk")]
  Ink = 5
}
