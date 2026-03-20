
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoEServicesDialog` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoEServicesDialog
{
  /// <summary>
  /// Invokes `Close`.
  /// </summary>
  /// <param name="ApplyWebComponentChanges">The `ApplyWebComponentChanges` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.close?view=office-pia
  /// </remarks>
  public void Close(bool ApplyWebComponentChanges);
  /// <summary>
  /// Invokes `AddTrustedDomain`.
  /// </summary>
  /// <param name="Domain">The `Domain` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.addtrusteddomain?view=office-pia
  /// </remarks>
  public void AddTrustedDomain(string Domain);
}
