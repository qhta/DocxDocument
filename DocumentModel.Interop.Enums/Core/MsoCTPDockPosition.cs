namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the docking behavior of the custom task pane.
/// </summary>
public enum MsoCTPDockPosition
{
  /// <summary>
  /// Dock the task pane on the left side of the document window.
  /// </summary>
  msoCTPDockPositionLeft,
  /// <summary>
  /// Dock the task pane at the top of the document window.
  /// </summary>
  msoCTPDockPositionTop,
  /// <summary>
  /// Dock the task pane on the right side of the document window. msoCTPDockPositionBottom3 Dock the task pane at
  /// the bottom of the document window. msoCTPDockPositionFloating4 Don't dock the task pane.
  /// </summary>
  msoCTPDockPositionRight,
  /// <summary>
  /// Specifies the docking behavior of the custom task pane.
  /// </summary>
  msoCTPDockPositionBottom,
  /// <summary>
  /// Specifies the docking behavior of the custom task pane.
  /// </summary>
  msoCTPDockPositionFloating
}
