
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog?view=office-pia"/>
public partial class MsoEServicesDialog
{
  /// <summary>
  /// Gets the `ApplicationName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.applicationname?view=office-pia"/>
  public string ApplicationName { get; }
  /// <summary>
  /// Gets the `WebComponent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.webcomponent?view=office-pia"/>
  public object WebComponent { get; }
  /// <summary>
  /// Gets the `ClipArt` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.clipart?view=office-pia"/>
  public object ClipArt { get; }


  #region methods

/// <summary>
  /// Closes the eServices dialog.
  /// </summary>
  /// <param name="ApplyWebComponentChanges">The `ApplyWebComponentChanges` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.close?view=office-pia"/>
  public void Close(bool ApplyWebComponentChanges) { throw new NotImplementedException(); }
  /// <summary>
  /// Adds a trusted domain.
  /// </summary>
  /// <param name="Domain">The `Domain` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.addtrusteddomain?view=office-pia"/>
  public void AddTrustedDomain(string Domain) { throw new NotImplementedException(); }

  #endregion methods
}


