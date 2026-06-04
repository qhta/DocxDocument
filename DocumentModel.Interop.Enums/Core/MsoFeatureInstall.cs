namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how the application handles calls to methods and properties that require features not yet installed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofeatureinstall?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFeatureInstall))]
public enum FeatureInstall
{
  /// <summary>
  /// Generates a generic automation error at run time when uninstalled features are called.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFeatureInstall.msoFeatureInstallNone))]
  None,
  /// <summary>
  /// Prompts the user to install new features.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFeatureInstall.msoFeatureInstallOnDemand))]
  OnDemand,
  /// <summary>
  /// Displays a progress meter during installation; does not prompt the user to install new features.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFeatureInstall.msoFeatureInstallOnDemandWithUI))]
  OnDemandWithUI
}
