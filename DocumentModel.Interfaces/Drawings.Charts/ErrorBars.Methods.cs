
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents error bars in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars?view=office-pia"/>
public partial interface IErrorBars: IModelObject
{
  /// <summary>
  /// Selects the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Clears formatting from the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.clearformats?view=office-pia"/>
  public object ClearFormats();
}

