namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which icon, if any, to display with an alert.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoalerticontype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoAlertIconType")]
public enum AlertIconType
{
  /// <summary>
  /// Displays no icon with the alert message.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertIconNoIcon")]
  NoIcon,
  /// <summary>
  /// Displays the Critical icon.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertIconCritical")]
  Critical,
  /// <summary>
  /// Displays the Query icon.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertIconQuery")]
  Query,
  /// <summary>
  /// Displays the Warning icon.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertIconWarning")]
  Warning,
  /// <summary>
  /// Displays the Info icon.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertIconInfo")]
  Info
}
