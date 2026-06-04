namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the security mode an application uses when programmatically opening files.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautomationsecurity?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoAutomationSecurity))]
public enum AutomationSecurity
{
  /// <summary>
  /// Enables all macros. This is the default value when the application is started.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutomationSecurity.msoAutomationSecurityLow))]
  Low = 1,
  /// <summary>
  /// Uses the security setting specified in the Security dialog box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutomationSecurity.msoAutomationSecurityByUI))]
  ByUI,
  /// <summary>
  /// Disables all macros in all files opened programmatically, without showing any security alerts.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutomationSecurity.msoAutomationSecurityForceDisable))]
  ForceDisable
}
