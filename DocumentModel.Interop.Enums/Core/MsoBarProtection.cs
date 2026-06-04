namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a command bar is protected from user customization.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobarprotection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBarProtection")]
public enum BarProtection
{
  /// <summary>
  /// All aspects of command bar can be customized by user.
  /// </summary>
  [OfficeInteropEnumValue("msoBarNoProtection")]
  Protection = 0,
  /// <summary>
  /// Command bar cannot be customized.
  /// </summary>
  [OfficeInteropEnumValue("msoBarNoCustomize")]
  Customize = 1,
  /// <summary>
  /// Command bar cannot be resized.
  /// </summary>
  [OfficeInteropEnumValue("msoBarNoResize")]
  Resize = 2,
  /// <summary>
  /// Command bar cannot be moved.
  /// </summary>
  [OfficeInteropEnumValue("msoBarNoMove")]
  Move = 4,
  /// <summary>
  /// Command bar cannot be hidden.
  /// </summary>
  [OfficeInteropEnumValue("msoBarNoChangeVisible")]
  ChangeVisible = 8,
  /// <summary>
  /// Docking setting cannot be changed.
  /// </summary>
  [OfficeInteropEnumValue("msoBarNoChangeDock")]
  ChangeDock = 0x10,
  /// <summary>
  /// Command bar cannot be docked to the left or right.
  /// </summary>
  [OfficeInteropEnumValue("msoBarNoVerticalDock")]
  VerticalDock = 0x20,
  /// <summary>
  /// Command bar cannot be docked to the top or bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoBarNoHorizontalDock")]
  HorizontalDock = 0x40
}
