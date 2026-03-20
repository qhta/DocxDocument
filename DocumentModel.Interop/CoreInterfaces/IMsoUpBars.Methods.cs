
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents up bars in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars?view=office-pia
/// </remarks>
public partial interface IMsoUpBars
{
  /// <summary>
  /// Selects the up bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Deletes the up bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.delete?view=office-pia
  /// </remarks>
  public object Delete();
}
