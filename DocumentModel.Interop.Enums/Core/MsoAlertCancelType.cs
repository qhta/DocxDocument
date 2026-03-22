namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies behavior when the user cancels an alert. Only msoAlertCancelDefault is currently supported.
/// </summary>
public enum MsoAlertCancelType
{
  /// <summary>
  /// Specifies behavior when the user cancels an alert. Only msoAlertCancelDefault is currently supported.
  /// </summary>
  Default = -1,
  /// <summary>
  /// Not supported.
  /// </summary>
  First,
  /// <summary>
  /// Not supported.
  /// </summary>
  Second,
  /// <summary>
  /// Not supported.
  /// </summary>
  Third,
  /// <summary>
  /// Not supported.
  /// </summary>
  Fourth,
  /// <summary>
  /// Not supported.
  /// </summary>
  Fifth
}
