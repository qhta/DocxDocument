namespace DocumentModel.Application;

/// <summary>
/// Specifies which icon, if any, to display with an alert.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoalerticontype?view=office-pia` for Office interop details.
/// </remarks>
public enum AlertIconType
{
  /// <summary>
  /// Displays no icon with the alert message.
  /// </summary>
  NoIcon,
  /// <summary>
  /// Displays the Critical icon.
  /// </summary>
  Critical,
  /// <summary>
  /// Displays the Query icon.
  /// </summary>
  Query,
  /// <summary>
  /// Displays the Warning icon.
  /// </summary>
  Warning,
  /// <summary>
  /// Displays the Info icon.
  /// </summary>
  Info
}
