
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the end
/// style for error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlendstylecap?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlEndStyleCap))]
public enum EndStyleCap
{
  /// <summary>
  /// No caps applied.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlEndStyleCap.xlCap))]
  Cap = 1,
  /// <summary>
  /// No caps applied.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlEndStyleCap.xlNoCap))]
  NoCap
}
