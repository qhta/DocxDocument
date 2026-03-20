
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the floor of a 3-D chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsofloor?view=office-pia
/// </remarks>
public partial interface IMsoFloor
{
  /// <summary>
  /// Selects the chart floor.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsofloor.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Clears formatting from the chart floor.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsofloor.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Pastes content onto the chart floor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsofloor.paste?view=office-pia
  /// </remarks>
  public void Paste();
}
