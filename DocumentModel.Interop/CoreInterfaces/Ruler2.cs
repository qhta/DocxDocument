
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the ruler for text in a shape or text style.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2?view=office-pia"/>
public interface IRuler2: IInteropObject
{
  /// <summary>
  /// Gets outline text formatting levels for the ruler.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2.levels?view=office-pia"/>
  public RulerLevels2 Levels { get; }
  /// <summary>
  /// Gets the tab stops for the ruler.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2.tabstops?view=office-pia"/>
  public TabStops2 TabStops { get; }
}

