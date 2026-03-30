
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a trendline in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline?view=office-pia"/>
public partial interface Trendline: IModelObject
{
  /// <summary>
  /// Clears formatting from the trendline.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.clearformats?view=office-pia"/>
  public object ClearFormats();
  /// <summary>
  /// Deletes the trendline.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the trendline.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.select?view=office-pia"/>
  public object Select();
}

