
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog?view=office-pia
/// </remarks>
public partial interface IMsoEServicesDialog
{
  /// <summary>
  /// Closes the eServices dialog.
  /// </summary>
  /// <param name="ApplyWebComponentChanges">The `ApplyWebComponentChanges` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.close?view=office-pia
  /// </remarks>
  public void Close(bool ApplyWebComponentChanges);
  /// <summary>
  /// Adds a trusted domain.
  /// </summary>
  /// <param name="Domain">The `Domain` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.addtrusteddomain?view=office-pia
  /// </remarks>
  public void AddTrustedDomain(string Domain);
}
