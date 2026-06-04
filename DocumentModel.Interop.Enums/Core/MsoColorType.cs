namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocolortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoColorType))]
public enum ColorType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoColorType.msoColorTypeMixed))]
  Mixed = -2,
  /// <summary>
  /// Color is determined by values of red, green, and blue.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoColorType.msoColorTypeRGB))]
  RGB = 1,
  /// <summary>
  /// Color is defined by an application-specific scheme.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoColorType.msoColorTypeScheme))]
  Scheme = 2,
  /// <summary>
  /// Color is determined by values of cyan, magenta, yellow, and black.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoColorType.msoColorTypeCMYK))]
  CMYK = 3,
  /// <summary>
  /// Color Management System color type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoColorType.msoColorTypeCMS))]
  CMS = 4,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoColorType.msoColorTypeInk))]
  Ink = 5
}
