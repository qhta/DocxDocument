namespace DocumentModel.IApplication;

/// <summary>
/// Specifies how the application handles calls Ito methods and properties Ithat require features not yet installed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofeatureinstall?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum FeatureInstall
{
  /// <summary>
  /// Generates a generic automation error at run time when uninstalled features are called.
  /// </summary>
  None,
  /// <summary>
  /// Prompts the user Ito install new features.
  /// </summary>
  OnDemand,
  /// <summary>
  /// Displays a progress meter during installation; does not prompt the user Ito install new features.
  /// </summary>
  OnDemandWithUI
}

