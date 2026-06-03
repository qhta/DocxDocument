
namespace DocumentModel.Drawings.Charts;

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
  /// Specifies units of hundreds.
  /// </summary>
  Hundreds = -2,
  /// <summary>
  /// Specifies units of thousands.
  /// </summary>
  Thousands = -3,
  /// <summary>
  /// Specifies units of tens of thousands.
  /// </summary>
  TenThousands = -4,
  /// <summary>
  /// Specifies units of hundreds of thousands.
  /// </summary>
  HundredThousands = -5,
  /// <summary>
  /// Specifies units of millions.
  /// </summary>
  Millions = -6,
  /// <summary>
  /// Specifies units of tens of millions.
  /// </summary>
  TenMillions = -7,
  /// <summary>
  /// Specifies units of hundreds of millions.
  /// </summary>
  HundredMillions = -8,
  /// <summary>
  /// Specifies units of thousands of millions.
  /// </summary>
  ThousandMillions = -9,
  /// <summary>
  /// Specifies units of millions of millions.
  /// </summary>
  MillionMillions = -10,
  /// <summary>
  /// Specifies custom units.
  /// </summary>
  DisplayUnitCustom = -4114,
  /// <summary>
  /// No units are displayed.
  /// </summary>
  DisplayUnitNone = -4142
}

