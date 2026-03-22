namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which icon, if any, to display with an alert.
/// </summary>
public enum MsoAlertIconType
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
