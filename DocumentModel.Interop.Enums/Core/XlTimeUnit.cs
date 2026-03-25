
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
  /// Specifies Day units.
  /// </summary>
  Days,
  /// <summary>
  /// Specifies Month units.
  /// </summary>
  Months,
  /// <summary>
  /// Specifies Year units.
  /// </summary>
  Years
}
