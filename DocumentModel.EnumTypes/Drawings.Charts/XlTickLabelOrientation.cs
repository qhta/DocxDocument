
namespace DocumentModel.Drawings.Charts;

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
  /// Text orientation set by Excel.
  /// </summary>
  Automatic = -4105,
  /// <summary>
  /// Text runs down.
  /// </summary>
  Downward = -4170,
  /// <summary>
  /// ICharacters run horizontally.
  /// </summary>
  Horizontal = -4128,
  /// <summary>
  /// Text runs up.
  /// </summary>
  Upward = -4171,
  /// <summary>
  /// ICharacters run vertically.
  /// </summary>
  Vertical = -4166
}

