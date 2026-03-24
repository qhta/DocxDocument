
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates units of
/// time measurement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xltimeunit?view=office-pia` for Office interop details.
/// </remarks>
public enum XlTimeUnit
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies Day units.
  /// xlMonths1 You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies
  /// Month units.
  /// </summary>
  Days,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates units of
  /// time measurement.
  /// </summary>
  Months,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies Year
  /// units.
  /// </summary>
  Years
}
