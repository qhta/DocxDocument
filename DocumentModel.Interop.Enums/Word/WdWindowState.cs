namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of the current document window or task window.
/// </summary>
public enum WdWindowState
{
  /// <summary>
  /// Normal.
  /// </summary>
  Normal = unchecked((int)0),
  /// <summary>
  /// Maximized.
  /// </summary>
  Maximize = unchecked((int)1),
  /// <summary>
  /// Minimized.
  /// </summary>
  Minimize = unchecked((int)2)
}
