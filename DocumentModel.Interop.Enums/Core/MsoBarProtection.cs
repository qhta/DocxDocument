namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a command bar is protected from user customization.
/// </summary>
public enum MsoBarProtection
{
  /// <summary>
  /// All aspects of command bar can be customized by user.
  /// </summary>
  Protection = 0,
  /// <summary>
  /// Command bar cannot be customized.
  /// </summary>
  Customize = 1,
  /// <summary>
  /// Command bar cannot be resized.
  /// </summary>
  Resize = 2,
  /// <summary>
  /// Command bar cannot be moved. msoBarNoChangeVisible8 Command bar cannot be hidden.
  /// </summary>
  Move = 4,
  /// <summary>
  /// Specifies how a command bar is protected from user customization.
  /// </summary>
  ChangeVisible = 8,
  /// <summary>
  /// Docking setting cannot be changed.
  /// </summary>
  ChangeDock = 0x10,
  /// <summary>
  /// Command bar cannot be docked to the left or right. msoBarNoHorizontalDock64 Command bar cannot be docked to
  /// the top or bottom.
  /// </summary>
  VerticalDock = 0x20,
  /// <summary>
  /// Specifies how a command bar is protected from user customization.
  /// </summary>
  HorizontalDock = 0x40
}
