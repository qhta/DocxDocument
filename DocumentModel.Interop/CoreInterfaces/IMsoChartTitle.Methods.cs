
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart title.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle?view=office-pia
/// </remarks>
public partial interface IMsoChartTitle
{
  /// <summary>
  /// Deletes the chart title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Selects the chart title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.select?view=office-pia
  /// </remarks>
  public object Select();
}
