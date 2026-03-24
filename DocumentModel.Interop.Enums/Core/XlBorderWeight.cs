
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the weight
/// of the border around a range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlborderweight?view=office-pia` for Office interop details.
/// </remarks>
public enum XlBorderWeight
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the weight
  /// of the border around a range.
  /// </summary>
  Hairline = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the weight
  /// of the border around a range.
  /// </summary>
  Medium = -4138,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Thick (widest
  /// border).
  /// </summary>
  Thick = 4,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Thin.
  /// </summary>
  Thin = 2
}
