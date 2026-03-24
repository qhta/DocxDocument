
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the text
/// orientation for tick-mark labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlticklabelorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum XlTickLabelOrientation
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Text orientation set
  /// by Excel.
  /// </summary>
  Automatic = -4105,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Text runs down.
  /// </summary>
  Downward = -4170,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Characters run
  /// horizontally.
  /// </summary>
  Horizontal = -4128,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Text runs up.
  /// </summary>
  Upward = -4171,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Characters run
  /// vertically.
  /// </summary>
  Vertical = -4166
}
