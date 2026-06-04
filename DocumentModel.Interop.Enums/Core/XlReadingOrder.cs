
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlreadingorder?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlReadingOrder")]
public enum ReadingOrder
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlContext")]
  Context = -5002,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlLTR")]
  LTR = -5003,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlRTL")]
  RTL = -5004
}
