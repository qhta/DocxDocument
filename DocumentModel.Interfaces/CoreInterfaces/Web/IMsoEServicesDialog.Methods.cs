
namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog?view=office-pia"/>
public partial interface EServicesDialog: InteropObject
{
  /// <summary>
  /// Closes the eServices dialog.
  /// </summary>
  /// <param name="ApplyWebComponentChanges">The `ApplyWebComponentChanges` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.close?view=office-pia"/>
  public void Close(bool ApplyWebComponentChanges);
  /// <summary>
  /// Adds a trusted domain.
  /// </summary>
  /// <param name="Domain">The `Domain` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.addtrusteddomain?view=office-pia"/>
  public void AddTrustedDomain(string Domain);
}

