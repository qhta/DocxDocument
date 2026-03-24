namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the window arrangement.
/// </summary>
public enum WdArrangeStyle
{
  /// <summary>
  /// Windows are tiled into a single window.
  /// </summary>
  Tiled = unchecked((int)0),
  /// <summary>
  /// Windows are displayed as icons in a single window.
  /// </summary>
  Icons = unchecked((int)1)
}
