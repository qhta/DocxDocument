namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the window arrangement.
/// </summary>
public enum WdArrangeStyle
{
  /// <summary>
  /// Windows are tiled into a single window.
  /// </summary>
  wdTiled = unchecked((int)0),
  /// <summary>
  /// Windows are displayed as icons in a single window.
  /// </summary>
  wdIcons = unchecked((int)1)
}
