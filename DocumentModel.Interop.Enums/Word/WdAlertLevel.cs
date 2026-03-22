namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way certain alerts and messages are handled while a macro is running.
/// </summary>
public enum WdAlertLevel
{
  /// <summary>
  /// No alerts or message boxes are displayed. If a macro encounters a message box, the default value is chosen and
  /// the macro continues.
  /// </summary>
  wdAlertsNone = unchecked((int)0),
  /// <summary>
  /// Specifies the way certain alerts and messages are handled while a macro is running.
  /// </summary>
  wdAlertsMessageBox = unchecked((int)-2),
  /// <summary>
  /// Specifies the way certain alerts and messages are handled while a macro is running.
  /// </summary>
  wdAlertsAll = unchecked((int)-1)
}
