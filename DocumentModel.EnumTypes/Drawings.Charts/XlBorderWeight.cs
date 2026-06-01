
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the weight
/// of the border around a range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlborderweight?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlBorderWeight
{
  /// <summary>
  /// Hairline (thinnest border).
  /// </summary>
  Hairline = 1,
  /// <summary>
  /// Medium.
  /// </summary>
  Medium = -4138,
  /// <summary>
  /// Thick (widest border).
  /// </summary>
  Thick = 4,
  /// <summary>
  /// Thin.
  /// </summary>
  Thin = 2
}

