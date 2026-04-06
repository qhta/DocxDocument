
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a chart axis.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis?view=office-pia"/>
public partial interface IAxis: IModelObject
{
  /// <summary>
  /// Deletes the axis.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the axis.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.select?view=office-pia"/>
  public object Select();
}

