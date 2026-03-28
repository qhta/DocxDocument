namespace DocumentModel;

/// <summary>
/// Specifies the state of the current document window or task window.
/// </summary>
public enum WindowState
{
  /// <summary>
  /// Normal.
  /// </summary>
  wdWindowStateNormal = unchecked((int)0),
  /// <summary>
  /// Maximized.
  /// </summary>
  wdWindowStateMaximize = unchecked((int)1),
  /// <summary>
  /// Minimized.
  /// </summary>
  wdWindowStateMinimize = unchecked((int)2)
}
