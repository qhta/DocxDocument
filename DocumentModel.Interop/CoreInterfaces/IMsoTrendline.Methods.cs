
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a trendline in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline?view=office-pia
/// </remarks>
public partial interface IMsoTrendline
{
  /// <summary>
  /// Clears formatting from the trendline.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Deletes the trendline.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Selects the trendline.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.select?view=office-pia
  /// </remarks>
  public object Select();
}
