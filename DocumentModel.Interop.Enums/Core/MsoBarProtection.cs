namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a command bar is protected from user customization.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobarprotection?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBarProtection")]
public enum BarProtection
{
  /// <summary>
  /// All aspects of command bar can be customized by user.
  /// </summary>
  [InteropEnumValue("msoBarNoProtection")]
  Protection = 0,
  /// <summary>
  /// Command bar cannot be customized.
  /// </summary>
  [InteropEnumValue("msoBarNoCustomize")]
  Customize = 1,
  /// <summary>
  /// Command bar cannot be resized.
  /// </summary>
  [InteropEnumValue("msoBarNoResize")]
  Resize = 2,
  /// <summary>
  /// Command bar cannot be moved.
  /// </summary>
  [InteropEnumValue("msoBarNoMove")]
  Move = 4,
  /// <summary>
  /// Command bar cannot be hidden.
  /// </summary>
  [InteropEnumValue("msoBarNoChangeVisible")]
  ChangeVisible = 8,
  /// <summary>
  /// Docking setting cannot be changed.
  /// </summary>
  [InteropEnumValue("msoBarNoChangeDock")]
  ChangeDock = 0x10,
  /// <summary>
  /// Command bar cannot be docked to the left or right.
  /// </summary>
  [InteropEnumValue("msoBarNoVerticalDock")]
  VerticalDock = 0x20,
  /// <summary>
  /// Command bar cannot be docked to the top or bottom.
  /// </summary>
  [InteropEnumValue("msoBarNoHorizontalDock")]
  HorizontalDock = 0x40
}
