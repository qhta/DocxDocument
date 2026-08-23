
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a legend entry in a chart legend.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry?view=office-pia"/>
public partial interface ILegendEntry : IModelObject
{
  /// <summary>
  /// Deletes the legend entry.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the legend entry.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.select?view=office-pia"/>
  public object Select();
}

