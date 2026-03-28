namespace DocumentModel.Application;

/// <summary>
/// Specifies how the application handles calls to methods and properties that require features not yet installed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofeatureinstall?view=office-pia` for Office interop details.
/// </remarks>
public enum FeatureInstall
{
  /// <summary>
  /// Generates a generic automation error at run time when uninstalled features are called.
  /// </summary>
  None,
  /// <summary>
  /// Prompts the user to install new features.
  /// </summary>
  OnDemand,
  /// <summary>
  /// Displays a progress meter during installation; does not prompt the user to install new features.
  /// </summary>
  OnDemandWithUI
}
