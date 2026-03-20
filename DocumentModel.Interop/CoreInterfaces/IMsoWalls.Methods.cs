
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart walls.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls?view=office-pia
/// </remarks>
public partial interface IMsoWalls
{
  /// <summary>
  /// Selects the chart walls.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Clears formatting from the chart walls.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Pastes content onto the chart walls.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.paste?view=office-pia
  /// </remarks>
  public void Paste();
}
