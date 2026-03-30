
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents chart corners.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia"/>
public partial interface Corners: IModelObject
{
  /// <summary>
  /// Selects the chart corners.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.select?view=office-pia"/>
  public object Select();
}

