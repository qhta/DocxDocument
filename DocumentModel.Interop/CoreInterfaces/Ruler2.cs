
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Ruler2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Ruler2: InteropObject
{
  /// <summary>
  /// Gets the `Levels` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2.levels?view=office-pia
  /// </remarks>
  public RulerLevels2 Levels { get; }
  /// <summary>
  /// Gets the `TabStops` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2.tabstops?view=office-pia
  /// </remarks>
  public TabStops2 TabStops { get; }
}
