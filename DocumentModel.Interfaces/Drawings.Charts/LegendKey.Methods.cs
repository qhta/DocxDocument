
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a legend key in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey?view=office-pia"/>
public partial interface ILegendKey: IModelObject
{
  /// <summary>
  /// Clears formatting from the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.clearformats?view=office-pia"/>
  public object ClearFormats();
  /// <summary>
  /// Deletes the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.select?view=office-pia"/>
  public object Select();
}

