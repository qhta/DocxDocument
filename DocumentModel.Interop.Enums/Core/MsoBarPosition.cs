namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the position or behavior of a command bar.
/// </summary>
public enum MsoBarPosition
{
  /// <summary>
  /// Command bar is docked on the left side of the application window.
  /// </summary>
  msoBarLeft,
  /// <summary>
  /// Command bar is docked at the top of the application window.
  /// </summary>
  msoBarTop,
  /// <summary>
  /// Command bar is docked on the right side of the application window.
  /// </summary>
  msoBarRight,
  /// <summary>
  /// Command bar is docked at the bottom of the application window. msoBarFloating4 Command bar floats on top of
  /// the application window.
  /// </summary>
  msoBarBottom,
  /// <summary>
  /// Specifies the position or behavior of a command bar.
  /// </summary>
  msoBarFloating,
  /// <summary>
  /// Command bar will be a shortcut menu. msoBarMenuBar6 Command bar will be a menu bar (Macintosh only).
  /// </summary>
  msoBarPopup,
  /// <summary>
  /// Specifies the position or behavior of a command bar.
  /// </summary>
  msoBarMenuBar
}
