namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the security mode an application uses when programmatically opening files.
/// </summary>
public enum MsoAutomationSecurity
{
  /// <summary>
  /// Enables all macros. This is the default value when the application is started.
  /// </summary>
  msoAutomationSecurityLow = 1,
  /// <summary>
  /// Uses the security setting specified in the Security dialog box. msoAutomationSecurityForceDisable3 Disables
  /// all macros in all files opened programmatically, without showing any security alerts.
  /// </summary>
  msoAutomationSecurityByUI,
  /// <summary>
  /// Specifies the security mode an application uses when programmatically opening files.
  /// </summary>
  msoAutomationSecurityForceDisable
}
