namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the appearance of a command bar button control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobuttonstate?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoButtonState
{
  /// <summary>
  /// Button is not pressed down.
  /// </summary>
  Up = 0,
  /// <summary>
  /// Button is pressed down.
  /// </summary>
  Down = -1,
  /// <summary>
  /// Button is pressed down.
  /// </summary>
  Mixed = 2
}
