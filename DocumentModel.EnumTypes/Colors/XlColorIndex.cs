
namespace DocumentModel;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the color
/// of a selected feature such as border, font, or fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlcolorindex?view=office-pia` for Office interop details.
/// </remarks>
public enum XlColorIndex
{
  /// <summary>
  /// Automatic color.
  /// </summary>
  Automatic = -4105,
  /// <summary>
  /// No color.
  /// </summary>
  None = -4142
}
