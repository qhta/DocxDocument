namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the style of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum ArrowheadStyle
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
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
  /// Stealth-shaped.
  /// </summary>
  Stealth = 4,
  /// <summary>
  /// Diamond-shaped.
  /// </summary>
  Diamond = 5,
  /// <summary>
  /// Oval-shaped.
  /// </summary>
  Oval = 6
}

