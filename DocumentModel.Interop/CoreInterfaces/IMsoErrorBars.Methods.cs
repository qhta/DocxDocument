
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents error bars in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars?view=office-pia
/// </remarks>
public partial interface IMsoErrorBars
{
  /// <summary>
  /// Selects the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Deletes the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Clears formatting from the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
}
