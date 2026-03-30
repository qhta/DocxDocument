
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents chart walls.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls?view=office-pia"/>
public partial interface IWalls: IModelObject
{
  /// <summary>
  /// Selects the chart walls.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Clears formatting from the chart walls.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.clearformats?view=office-pia"/>
  public object ClearFormats();
  /// <summary>
  /// Pastes content onto the chart walls.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.paste?view=office-pia"/>
  public void Paste();
}

