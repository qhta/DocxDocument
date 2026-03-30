
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents tick labels on a chart axis.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels?view=office-pia"/>
public partial interface ITickLabels: IModelObject
{
  /// <summary>
  /// Deletes the tick labels.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the tick labels.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.select?view=office-pia"/>
  public object Select();
}

