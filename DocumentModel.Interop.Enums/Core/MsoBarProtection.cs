namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a command bar is protected from user customization.
/// </summary>
public enum MsoBarProtection
{
  /// <summary>
  /// All aspects of command bar can be customized by user.
  /// </summary>
  msoBarNoProtection = 0,
  /// <summary>
  /// Command bar cannot be customized.
  /// </summary>
  msoBarNoCustomize = 1,
  /// <summary>
  /// Command bar cannot be resized.
  /// </summary>
  msoBarNoResize = 2,
  /// <summary>
  /// Command bar cannot be moved. msoBarNoChangeVisible8 Command bar cannot be hidden.
  /// </summary>
  msoBarNoMove = 4,
  /// <summary>
  /// Specifies how a command bar is protected from user customization.
  /// </summary>
  msoBarNoChangeVisible = 8,
  /// <summary>
  /// Docking setting cannot be changed.
  /// </summary>
  msoBarNoChangeDock = 0x10,
  /// <summary>
  /// Command bar cannot be docked to the left or right. msoBarNoHorizontalDock64 Command bar cannot be docked to
  /// the top or bottom.
  /// </summary>
  msoBarNoVerticalDock = 0x20,
  /// <summary>
  /// Specifies how a command bar is protected from user customization.
  /// </summary>
  msoBarNoHorizontalDock = 0x40
}
