
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the weight
/// of the border around a range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlborderweight?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlBorderWeight")]
public enum BorderWeight
{
  /// <summary>
  /// Hairline (thinnest border).
  /// </summary>
  [OfficeInteropEnumValue("xlHairline")]
  Hairline = 1,
  /// <summary>
  /// Medium.
  /// </summary>
  [OfficeInteropEnumValue("xlMedium")]
  Medium = -4138,
  /// <summary>
  /// Thick (widest border).
  /// </summary>
  [OfficeInteropEnumValue("xlThick")]
  Thick = 4,
  /// <summary>
  /// Thin.
  /// </summary>
  [OfficeInteropEnumValue("xlThin")]
  Thin = 2
}
