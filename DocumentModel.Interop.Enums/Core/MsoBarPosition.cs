namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the position or behavior of a command bar.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobarposition?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBarPosition")]
public enum BarPosition
{
  /// <summary>
  /// Command bar is docked on the left side of the application window.
  /// </summary>
  [OfficeInteropEnumValue("msoBarLeft")]
  Left,
  /// <summary>
  /// Command bar is docked at the top of the application window.
  /// </summary>
  [OfficeInteropEnumValue("msoBarTop")]
  Top,
  /// <summary>
  /// Command bar is docked on the right side of the application window.
  /// </summary>
  [OfficeInteropEnumValue("msoBarRight")]
  Right,
  /// <summary>
  /// Command bar is docked at the bottom of the application window.
  /// </summary>
  [OfficeInteropEnumValue("msoBarBottom")]
  Bottom,
  /// <summary>
  /// Command bar floats on top of the application window.
  /// </summary>
  [OfficeInteropEnumValue("msoBarFloating")]
  Floating,
  /// <summary>
  /// Command bar will be a shortcut menu.
  /// </summary>
  [OfficeInteropEnumValue("msoBarPopup")]
  Popup,
  /// <summary>
  /// Command bar will be a menu bar (Macintosh only).
  /// </summary>
  [OfficeInteropEnumValue("msoBarMenuBar")]
  MenuBar
}
