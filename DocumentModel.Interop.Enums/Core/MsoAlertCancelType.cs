namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies behavior when the user cancels an alert. Only msoAlertCancelDefault is currently supported.
/// </summary>
public enum MsoAlertCancelType
{
  /// <summary>
  /// Specifies behavior when the user cancels an alert. Only msoAlertCancelDefault is currently supported.
  /// </summary>
  msoAlertCancelDefault = -1,
  /// <summary>
  /// Not supported.
  /// </summary>
  msoAlertCancelFirst,
  /// <summary>
  /// Not supported.
  /// </summary>
  msoAlertCancelSecond,
  /// <summary>
  /// Not supported.
  /// </summary>
  msoAlertCancelThird,
  /// <summary>
  /// Not supported.
  /// </summary>
  msoAlertCancelFourth,
  /// <summary>
  /// Not supported.
  /// </summary>
  msoAlertCancelFifth
}
