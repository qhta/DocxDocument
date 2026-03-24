
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates numeric
/// units of measurement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldisplayunit?view=office-pia` for Office interop details.
/// </remarks>
public enum XlDisplayUnit
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// hundreds.
  /// </summary>
  Hundreds = -2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// thousands.
  /// </summary>
  Thousands = -3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// tens of thousands.
  /// </summary>
  TenThousands = -4,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// hundreds of thousands.
  /// </summary>
  HundredThousands = -5,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// millions. public enum class XlDisplayUnit
  /// </summary>
  Millions = -6,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// tens of millions.
  /// </summary>
  TenMillions = -7,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// hundreds of millions.
  /// </summary>
  HundredMillions = -8,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// thousands of millions.
  /// </summary>
  ThousandMillions = -9,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies units of
  /// millions of millions.
  /// </summary>
  MillionMillions = -10,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies custom
  /// units.
  /// </summary>
  DisplayUnitCustom = -4114,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). No units are
  /// displayed.
  /// </summary>
  DisplayUnitNone = -4142
}
