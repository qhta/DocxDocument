
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates units of
/// time measurement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xltimeunit?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlTimeUnit")]
public enum TimeUnit
{
  /// <summary>
  /// Specifies Day units.
  /// </summary>
  [InteropEnumValue("xlDays")]
  Days,
  /// <summary>
  /// Specifies Month units.
  /// </summary>
  [InteropEnumValue("xlMonths")]
  Months,
  /// <summary>
  /// Specifies Year units.
  /// </summary>
  [InteropEnumValue("xlYears")]
  Years
}
