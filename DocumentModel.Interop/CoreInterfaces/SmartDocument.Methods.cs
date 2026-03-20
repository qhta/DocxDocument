
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartDocument` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SmartDocument
{
  /// <summary>
  /// Invokes `PickSolution`.
  /// </summary>
  /// <param name="ConsiderAllSchemas">The `ConsiderAllSchemas` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.picksolution?view=office-pia
  /// </remarks>
  public void PickSolution(bool ConsiderAllSchemas);
  /// <summary>
  /// Invokes `RefreshPane`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.refreshpane?view=office-pia
  /// </remarks>
  public void RefreshPane();
}
