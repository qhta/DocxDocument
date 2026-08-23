
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents down bars in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars?view=office-pia"/>
public partial interface IDownBars : IModelObject
{
  /// <summary>
  /// Selects the down bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the down bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.delete?view=office-pia"/>
  public object Delete();
}

