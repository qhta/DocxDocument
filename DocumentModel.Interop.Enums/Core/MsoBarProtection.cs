namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a command bar is protected from user customization.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobarprotection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoBarProtection))]
public enum BarProtection
{
  /// <summary>
  /// All aspects of command bar can be customized by user.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarProtection.msoBarNoProtection))]
  Protection = 0,
  /// <summary>
  /// Command bar cannot be customized.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarProtection.msoBarNoCustomize))]
  Customize = 1,
  /// <summary>
  /// Command bar cannot be resized.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarProtection.msoBarNoResize))]
  Resize = 2,
  /// <summary>
  /// Command bar cannot be moved.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarProtection.msoBarNoMove))]
  Move = 4,
  /// <summary>
  /// Command bar cannot be hidden.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarProtection.msoBarNoChangeVisible))]
  ChangeVisible = 8,
  /// <summary>
  /// Docking setting cannot be changed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarProtection.msoBarNoChangeDock))]
  ChangeDock = 0x10,
  /// <summary>
  /// Command bar cannot be docked to the left or right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarProtection.msoBarNoVerticalDock))]
  VerticalDock = 0x20,
  /// <summary>
  /// Command bar cannot be docked to the top or bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBarProtection.msoBarNoHorizontalDock))]
  HorizontalDock = 0x40
}
