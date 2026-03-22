namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the appearance of a command bar button control.
/// </summary>
public enum MsoButtonState
{
  /// <summary>
  /// Button is not pressed down.
  /// </summary>
  msoButtonUp = 0,
  /// <summary>
  /// Specifies the appearance of a command bar button control.
  /// </summary>
  msoButtonDown = -1,
  /// <summary>
  /// Button is pressed down.
  /// </summary>
  msoButtonMixed = 2
}
