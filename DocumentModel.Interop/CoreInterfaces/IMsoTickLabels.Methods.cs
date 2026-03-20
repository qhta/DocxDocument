
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents tick labels on a chart axis.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels?view=office-pia
/// </remarks>
public partial interface IMsoTickLabels
{
  /// <summary>
  /// Deletes the tick labels.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Selects the tick labels.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.select?view=office-pia
  /// </remarks>
  public object Select();
}
