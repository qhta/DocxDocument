namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which icon, if any, to display with an alert.
/// </summary>
public enum MsoAlertIconType
{
  /// <summary>
  /// Displays no icon with the alert message.
  /// </summary>
  msoAlertIconNoIcon,
  /// <summary>
  /// Displays the Critical icon.
  /// </summary>
  msoAlertIconCritical,
  /// <summary>
  /// Displays the Query icon.
  /// </summary>
  msoAlertIconQuery,
  /// <summary>
  /// Displays the Warning icon.
  /// </summary>
  msoAlertIconWarning,
  /// <summary>
  /// Displays the Info icon.
  /// </summary>
  msoAlertIconInfo
}
