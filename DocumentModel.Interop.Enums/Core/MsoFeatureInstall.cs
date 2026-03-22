namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how the application handles calls to methods and properties that require features not yet installed.
/// </summary>
public enum MsoFeatureInstall
{
  /// <summary>
  /// Generates a generic automation error at run time when uninstalled features are called.
  /// msoFeatureInstallOnDemand1 Prompts the user to install new features. msoFeatureInstallOnDemandWithUI2 Displays
  /// a progress meter during installation; does not prompt the user to install new features.
  /// </summary>
  msoFeatureInstallNone,
  /// <summary>
  /// Specifies how the application handles calls to methods and properties that require features not yet installed.
  /// </summary>
  msoFeatureInstallOnDemand,
  /// <summary>
  /// Specifies how the application handles calls to methods and properties that require features not yet installed.
  /// </summary>
  msoFeatureInstallOnDemandWithUI
}
