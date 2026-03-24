namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a command bar is protected from user customization.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobarprotection?view=office-pia` for Office interop details.
/// </remarks>
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
  /// Command bar cannot be moved.
  /// </summary>
  Move = 4,
  /// <summary>
  /// Command bar cannot be hidden.
  /// </summary>
  ChangeVisible = 8,
  /// <summary>
  /// Docking setting cannot be changed.
  /// </summary>
  ChangeDock = 0x10,
  /// <summary>
  /// Command bar cannot be docked to the left or right.
  /// </summary>
  VerticalDock = 0x20,
  /// <summary>
  /// Command bar cannot be docked to the top or bottom.
  /// </summary>
  HorizontalDock = 0x40
}
