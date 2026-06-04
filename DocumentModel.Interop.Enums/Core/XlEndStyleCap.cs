
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the end
/// style for error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlendstylecap?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlEndStyleCap")]
public enum EndStyleCap
{
  /// <summary>
  /// No caps applied.
  /// </summary>
  [InteropEnumValue("xlCap")]
  Cap = 1,
  /// <summary>
  /// No caps applied.
  /// </summary>
  [InteropEnumValue("xlNoCap")]
  NoCap
}
