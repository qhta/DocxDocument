
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a chart title.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle?view=office-pia"/>
public partial interface IChartTitle: IModelObject
{
  /// <summary>
  /// Deletes the chart title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the chart title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.select?view=office-pia"/>
  public object Select();
}

