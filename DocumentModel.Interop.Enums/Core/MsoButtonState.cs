namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the appearance of a command bar button control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobuttonstate?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoButtonState")]
public enum ButtonState
{
  /// <summary>
  /// Button is not pressed down.
  /// </summary>
  [InteropEnumValue("msoButtonUp")]
  Up = 0,
  /// <summary>
  /// Button is pressed down.
  /// </summary>
  [InteropEnumValue("msoButtonDown")]
  Down = -1,
  /// <summary>
  /// Button is pressed down.
  /// </summary>
  [InteropEnumValue("msoButtonMixed")]
  Mixed = 2
}
