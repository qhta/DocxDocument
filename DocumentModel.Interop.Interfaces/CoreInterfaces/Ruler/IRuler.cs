
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents the ruler for text in a shape or text style.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2?view=office-pia"/>
public interface IRuler: IInteropObject
{
  /// <summary>
  /// Gets outline text formatting levels for the ruler.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2.levels?view=office-pia"/>
  public IRulerLevels Levels { get; }
  /// <summary>
  /// Gets the tab stops for the ruler.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ruler2.tabstops?view=office-pia"/>
  public ITabStops TabStops { get; }
}	
