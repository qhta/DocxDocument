
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart corners.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia
/// </remarks>
public partial interface IMsoCorners
{
  /// <summary>
  /// Selects the chart corners.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.select?view=office-pia
  /// </remarks>
  public object Select();
}
