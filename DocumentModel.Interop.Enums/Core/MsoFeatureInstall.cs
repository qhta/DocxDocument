namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how the application handles calls to methods and properties that require features not yet installed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofeatureinstall?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoFeatureInstall
{
  /// <summary>
  /// Generates a generic automation error at run time when uninstalled features are called.
  /// msoFeatureInstallOnDemand1 Prompts the user to install new features. msoFeatureInstallOnDemandWithUI2 Displays
  /// a progress meter during installation; does not prompt the user to install new features.
  /// </summary>
  None,
  /// <summary>
  /// Specifies how the application handles calls to methods and properties that require features not yet installed.
  /// </summary>
  OnDemand,
  /// <summary>
  /// Specifies how the application handles calls to methods and properties that require features not yet installed.
  /// </summary>
  OnDemandWithUI
}
