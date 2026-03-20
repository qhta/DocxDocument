
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents down bars in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars?view=office-pia
/// </remarks>
public partial interface IMsoDownBars
{
  /// <summary>
  /// Selects the down bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Deletes the down bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.delete?view=office-pia
  /// </remarks>
  public object Delete();
}
