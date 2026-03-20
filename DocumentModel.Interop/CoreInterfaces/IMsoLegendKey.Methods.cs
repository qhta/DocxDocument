
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a legend key in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey?view=office-pia
/// </remarks>
public partial interface IMsoLegendKey
{
  /// <summary>
  /// Clears formatting from the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Deletes the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Selects the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.select?view=office-pia
  /// </remarks>
  public object Select();
}
