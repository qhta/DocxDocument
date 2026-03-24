namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the docking behavior of the custom task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoctpdockposition?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoCTPDockPosition
{
  /// <summary>
  /// Dock the task pane on the left side of the document window.
  /// </summary>
  Left,
  /// <summary>
  /// Dock the task pane at the top of the document window.
  /// </summary>
  Top,
  /// <summary>
  /// Dock the task pane on the right side of the document window. msoCTPDockPositionBottom3 Dock the task pane at
  /// the bottom of the document window. msoCTPDockPositionFloating4 Don't dock the task pane.
  /// </summary>
  Right,
  /// <summary>
  /// Specifies the docking behavior of the custom task pane.
  /// </summary>
  Bottom,
  /// <summary>
  /// Specifies the docking behavior of the custom task pane.
  /// </summary>
  Floating
}
