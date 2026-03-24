namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoArrowheadStyle
{
  /// <summary>
  /// Specifies the style of the arrowhead at the end of a line.
  /// </summary>
  StyleMixed = -2,
  /// <summary>
  /// No arrowhead.
  /// </summary>
  None = 1,
  /// <summary>
  /// Triangular.
  /// </summary>
  Triangle = 2,
  /// <summary>
  /// Open.
  /// </summary>
  Open = 3,
  /// <summary>
  /// Stealth-shaped. msoArrowheadDiamond5 Diamond-shaped.
  /// </summary>
  Stealth = 4,
  /// <summary>
  /// Specifies the style of the arrowhead at the end of a line.
  /// </summary>
  Diamond = 5,
  /// <summary>
  /// Oval-shaped.
  /// </summary>
  Oval = 6
}
