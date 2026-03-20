
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the ruler for text in a shape or text style.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2?view=office-pia
/// </remarks>
public partial interface Ruler2: InteropObject
{
  /// <summary>
  /// Gets outline text formatting levels for the ruler.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2.levels?view=office-pia
  /// </remarks>
  public RulerLevels2 Levels { get; }
  /// <summary>
  /// Gets the tab stops for the ruler.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2.tabstops?view=office-pia
  /// </remarks>
  public TabStops2 TabStops { get; }
}
