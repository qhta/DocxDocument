namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which icon, if any, to display with an alert.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoalerticontype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoAlertIconType")]
public enum AlertIconType
{
  /// <summary>
  /// Displays no icon with the alert message.
  /// </summary>
  [InteropEnumValue("msoAlertIconNoIcon")]
  NoIcon,
  /// <summary>
  /// Displays the Critical icon.
  /// </summary>
  [InteropEnumValue("msoAlertIconCritical")]
  Critical,
  /// <summary>
  /// Displays the Query icon.
  /// </summary>
  [InteropEnumValue("msoAlertIconQuery")]
  Query,
  /// <summary>
  /// Displays the Warning icon.
  /// </summary>
  [InteropEnumValue("msoAlertIconWarning")]
  Warning,
  /// <summary>
  /// Displays the Info icon.
  /// </summary>
  [InteropEnumValue("msoAlertIconInfo")]
  Info
}
