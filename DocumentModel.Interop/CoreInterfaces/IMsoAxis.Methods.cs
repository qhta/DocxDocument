
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart axis.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis?view=office-pia
/// </remarks>
public partial interface IMsoAxis
{
  /// <summary>
  /// Deletes the axis.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Selects the axis.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.select?view=office-pia
  /// </remarks>
  public object Select();
}
