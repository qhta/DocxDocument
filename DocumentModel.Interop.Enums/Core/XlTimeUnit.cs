
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates units of
/// time measurement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xltimeunit?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlTimeUnit")]
public enum TimeUnit
{
  /// <summary>
  /// Specifies Day units.
  /// </summary>
  [OfficeInteropEnumValue("xlDays")]
  Days,
  /// <summary>
  /// Specifies Month units.
  /// </summary>
  [OfficeInteropEnumValue("xlMonths")]
  Months,
  /// <summary>
  /// Specifies Year units.
  /// </summary>
  [OfficeInteropEnumValue("xlYears")]
  Years
}
